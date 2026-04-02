using System.Text.Json;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Shared.Messages.Enums;
using Shared.Messages.Interfaces;
using Shared.Messages.Requests;
using Shared.Messages.Responses;
using XLDENTProxy;
using XLDENTProxy.Interfaces;
using XLDENTProxy.Queries;

namespace Agent.Connection;

public sealed class AgentConnection(
    string hubUrl,
    string agentId,
    string apiKey,
    IServiceProvider services) : IAsyncDisposable
{
    private static readonly TimeSpan HeartbeatInterval = TimeSpan.FromSeconds(30);

    private HubConnection? _hub;

    public async Task StartAsync(CancellationToken ct = default)
    {
        _hub = new HubConnectionBuilder()
            .WithUrl(hubUrl)
            .WithAutomaticReconnect()
            .Build();

        // Unified handler: server calls Proxy(payload) and awaits a response.
        // Payload is received as JsonElement because the request type is not known
        // at compile time — we dispatch based on RequestType.
        _hub.On<JsonElement, IAgentResponse>("Proxy", async (payload) =>
        {
            var requestType = payload.TryGetProperty("RequestType", out var rt)
                ? rt.GetString()
                : null;

            Log.Debug("Proxy {RequestType}", requestType);
            try
            {
                return requestType switch
                {
                    AgentRequestType.GetHealth =>
                        await HandleHealthAsync(ct),

                    AgentRequestType.SearchAppointments =>
                        await HandleSearchAsync(
                            payload.Deserialize<SearchAppointmentsRequest>()
                                ?? throw new InvalidOperationException("Failed to deserialize SearchAppointmentsRequest."),
                            ct),

                    AgentRequestType.CancelAppointment =>
                        await HandleCancelAsync(
                            payload.Deserialize<CancelAppointmentRequest>()
                                ?? throw new InvalidOperationException("Failed to deserialize CancelAppointmentRequest."),
                            ct),

                    _ => (IAgentResponse)new AgentErrorResponse
                    {
                        Message = $"Unknown request type: '{requestType}'"
                    }
                };
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Proxy handler failed for RequestType={RequestType}", requestType);
                return new AgentErrorResponse { Message = ex.Message };
            }
        });

        await _hub.StartAsync(ct);
        await _hub.InvokeAsync("RegisterAsync", agentId, apiKey, ct);
        Log.Information("Agent connected as '{AgentId}' → {HubUrl}", agentId, hubUrl);

        _ = HeartbeatLoopAsync(ct);
    }

    // ── Proxy dispatch helpers ─────────────────────────────────────────────────

    private async Task<IAgentResponse> HandleHealthAsync(CancellationToken ct)
    {
        var dbConnected = await CheckDbAsync(ct);
        return new HealthResponse { DbConnected = dbConnected, CheckedAt = DateTimeOffset.UtcNow };
    }

    private async Task<IAgentResponse> HandleSearchAsync(SearchAppointmentsRequest req, CancellationToken ct)
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

        return new AppointmentsResponse
        {
            Data = JsonSerializer.Serialize(results)
        };
    }

    private async Task<IAgentResponse> HandleCancelAsync(CancelAppointmentRequest req, CancellationToken ct)
    {
        await using var scope = services.CreateAsyncScope();
        var svc = scope.ServiceProvider.GetRequiredService<IPatientAppointmentService>();
        var success = await svc.CancelAppointmentAsync(req.EventId);
        return new SuccessResponse { Value = success ? "Cancelled" : "Not found" };
    }

    // ── Heartbeat ──────────────────────────────────────────────────────────────

    private async Task HeartbeatLoopAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested && _hub?.State == HubConnectionState.Connected)
        {
            await Task.Delay(HeartbeatInterval, ct);
            var dbConnected = await CheckDbAsync(ct);
            try
            {
                if (_hub.State == HubConnectionState.Connected)
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
            await _hub.DisposeAsync();
    }
}
