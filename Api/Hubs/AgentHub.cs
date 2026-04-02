using Api.Services;
using Microsoft.AspNetCore.SignalR;

namespace Api.Hubs;

public sealed class AgentHub(AgentRegistry registry, IConfiguration config) : Hub
{
    public override Task OnDisconnectedAsync(Exception? exception)
    {
        registry.Unregister(Context.ConnectionId);
        return base.OnDisconnectedAsync(exception);
    }

    public Task RegisterAsync(string agentId, string apiKey)
    {
        var keys = config.GetSection("Agents").Get<Dictionary<string, string>>() ?? [];
        if (!keys.TryGetValue(agentId, out var expected) || expected != apiKey)
        {
            throw new HubException("Invalid agent ID or API key.");
        }

        registry.Register(agentId, Context.ConnectionId);
        Context.Items["AgentId"] = agentId;
        return Task.CompletedTask;
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
