using Agent;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Shared.Appointments;
using Shared.Messages.Interfaces;
using Shared.Messages.Requests;
using Shared.Messages.Responses;
using UrlCombineLib;
using XLDENTProxy;
using XLDENTProxy.Interfaces;

namespace Agent.Connection;

public sealed class AgentConnection(
    string hubUrl,
    string agentId,
    string apiKey,
    IServiceProvider services) : IAsyncDisposable
{
    private static readonly TimeSpan HeartbeatInterval = TimeSpan.FromMinutes(2);
    private static readonly DateTimeOffset StartedAt = DateTimeOffset.UtcNow;

    private HubConnection? _hub;

    public async Task StartAsync(CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(hubUrl))
            throw new InvalidOperationException("Server URL is not configured. Run the agent interactively to set it up.");

        _hub = new HubConnectionBuilder()
            .WithUrl(UrlCombine.Combine(hubUrl, "hubs/agent"))
            .WithAutomaticReconnect()
            .AddNewtonsoftJsonProtocol()
            .Build();

        _hub.On<IAgentRequest, IAgentResponse>("Proxy", async request =>
        {
            Log.Debug("Proxy {RequestType}", request.RequestType);
            try
            {
                return request switch
                {
                    GetHealthRequest => await HandleHealthAsync(ct),
                    SearchAppointmentsRequest search => await HandleSearchAsync(search),
                    CancelAppointmentRequest cancel => await HandleCancelAsync(cancel),

                    _ => new AgentErrorResponse
                    {
                        Message = $"Unknown request type: '{request.RequestType}'"
                    }
                };
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Proxy handler failed for RequestType={RequestType}", request.RequestType);
                return new AgentErrorResponse { Message = ex.Message };
            }
        });

        _hub.Reconnected += async newConnectionId =>
        {
            Log.Information("Reconnected to hub — re-registering agent '{AgentId}'", agentId);
            try
            {
                await _hub.InvokeAsync("RegisterAsync", agentId, apiKey, ct);
                _ = HeartbeatLoopAsync(ct);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Re-registration after reconnect failed");
            }
        };

        await _hub.StartAsync(ct);
        await _hub.InvokeAsync("RegisterAsync", agentId, apiKey, ct);
        Log.Information("Agent connected as '{AgentId}' → {HubUrl}", agentId, hubUrl);

        _ = HeartbeatLoopAsync(ct);
    }

    private async Task<IAgentResponse> HandleHealthAsync(CancellationToken ct)
    {
        var dbConnected = await CheckDbAsync(ct);

        var version = AgentVersion.Get();
        var updatedAt = AgentVersion.GetBuildDate();

        return new HealthResponse
        {
            DbConnected = dbConnected,
            CheckedAt   = DateTimeOffset.UtcNow,
            StartedAt   = StartedAt,
            Version     = version,
            UpdatedAt   = updatedAt,
        };
    }

    private async Task<IAgentResponse> HandleSearchAsync(SearchAppointmentsRequest req)
    {
        await using var scope = services.CreateAsyncScope();
        var svc = scope.ServiceProvider.GetRequiredService<IPatientAppointmentService>();

        var results = await svc.SearchAsync(new PatientSearchParams
        {
            Phone    = req.Phone,
            Email    = req.Email,
            Name     = req.Name,
            Address  = req.Address,
            EventId  = req.EventId,
            DateFrom = req.DateFrom,
            DateTo   = req.DateTo,
        });

        return new AppointmentsResponse { Data = results };
    }

    private async Task<IAgentResponse> HandleCancelAsync(CancelAppointmentRequest req)
    {
        await using var scope = services.CreateAsyncScope();
        var svc = scope.ServiceProvider.GetRequiredService<IPatientAppointmentService>();
        var success = await svc.CancelAppointmentAsync(req.EventId);
        return new SuccessResponse { Value = success ? "Cancelled" : "Not found" };
    }

    private async Task HeartbeatLoopAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested && _hub?.State != HubConnectionState.Disconnected)
        {
            await Task.Delay(HeartbeatInterval, ct);
            if (_hub?.State != HubConnectionState.Connected)
            {
                continue;
            }
            var dbConnected = await CheckDbAsync(ct);
            try
            {
                await _hub.InvokeAsync("HeartbeatAsync", dbConnected, ct);
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Heartbeat failed");
            }
        }
    }

    private async Task<bool> CheckDbAsync(CancellationToken ct)
    {
        try
        {
            await using var scope = services.CreateAsyncScope();
            var db = scope.ServiceProvider.GetRequiredService<DrDataContext>();
            return await db.Database.CanConnectAsync(ct);
        }
        catch
        {
            return false;
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_hub is not null)
        {
            await _hub.DisposeAsync();
        }
    }
}
