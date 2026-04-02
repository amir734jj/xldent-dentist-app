using Api.Data.Entities;
using Api.Services;
using EfCoreRepository;
using EfCoreRepository.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;

namespace Api.Hubs;

public sealed class AgentHub(AgentRegistry registry, IEfRepository repository, IMemoryCache cache) : Hub
{
    private const int MaxFailures   = 5;
    private static readonly TimeSpan LockoutDuration = TimeSpan.FromMinutes(15);

    private IBasicCrud<AgentApiKey> AgentApiKeysDal => repository.For<AgentApiKey>();

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        registry.Unregister(Context.ConnectionId);
        return base.OnDisconnectedAsync(exception);
    }

    public async Task RegisterAsync(string agentId, string apiKey)
    {
        var ip = Context.GetHttpContext()?.Connection.RemoteIpAddress?.ToString() ?? "unknown";
        var failKey = $"hub_fail:{ip}";

        if (cache.TryGetValue(failKey, out int failures) && failures >= MaxFailures)
        {
            throw new HubException("Too many failed attempts. Try again later.");
        }

        if (!Guid.TryParse(apiKey, out var apiKeyGuid))
        {
            Lockout(failKey);
            throw new HubException("Invalid agent ID or API key.");
        }

        var valid = await AgentApiKeysDal.Any(filterExprs: [
            k => k.Id == apiKeyGuid && k.AgentId == agentId
        ]);
        if (!valid)
        {
            Lockout(failKey);
            throw new HubException("Invalid agent ID or API key.");
        }

        cache.Remove(failKey);
        registry.Register(agentId, Context.ConnectionId);
        Context.Items["AgentId"] = agentId;
    }

    private void Lockout(string failKey)
    {
        var count = (cache.TryGetValue(failKey, out int c) ? c : 0) + 1;
        cache.Set(failKey, count, LockoutDuration);
    }

    public Task HeartbeatAsync(bool dbConnected)
    {
        if (Context.Items["AgentId"] is string agentId)
        {
            registry.UpdateHeartbeat(agentId, dbConnected);
        }

        return Task.CompletedTask;
    }

    public Task SendResultAsync(string requestId, string jsonResult)
    {
        registry.Complete(requestId, jsonResult);
        return Task.CompletedTask;
    }
}
