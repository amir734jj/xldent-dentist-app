using System.Collections.Concurrent;

namespace Api.Services;

public sealed class AgentRegistry
{
    private record AgentEntry(string ConnectionId, DateTimeOffset LastSeen, bool DbConnected);

    private readonly ConcurrentDictionary<string, AgentEntry> _agents = new();
    private readonly ConcurrentDictionary<string, TaskCompletionSource<string>> _pending = new();

    public void Register(string agentId, string connectionId)
    {
        _agents[agentId] = new(connectionId, DateTimeOffset.UtcNow, false);
    }

    public void Unregister(string connectionId)
    {
        foreach (var (id, entry) in _agents)
        {
            if (entry.ConnectionId == connectionId)
            {
                _agents.TryRemove(id, out _);
            }
        }
    }

    public void UpdateHeartbeat(string agentId, bool dbConnected)
    {
        if (_agents.TryGetValue(agentId, out var entry))
        {
            _agents[agentId] = entry with { LastSeen = DateTimeOffset.UtcNow, DbConnected = dbConnected };
        }
    }

    public string? GetConnectionId(string agentId)
    {
        return _agents.TryGetValue(agentId, out var entry) ? entry.ConnectionId : null;
    }

    public IReadOnlyList<string> ConnectedAgents()
    {
        return _agents.Keys.ToList();
    }

    public (string Status, DateTimeOffset? LastSeen, bool DbConnected) GetHealth(string agentId)
    {
        if (!_agents.TryGetValue(agentId, out var entry))
        {
            return ("offline", null, false);
        }

        var staleCutoff = DateTimeOffset.UtcNow.AddSeconds(-60);
        var status = entry.LastSeen < staleCutoff ? "offline"
            : entry.DbConnected ? "online"
            : "degraded";

        return (status, entry.LastSeen, entry.DbConnected);
    }

    public TaskCompletionSource<string> CreatePending(string requestId)
    {
        var tcs = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
        _pending[requestId] = tcs;
        return tcs;
    }

    public void Complete(string requestId, string result)
    {
        if (_pending.TryRemove(requestId, out var tcs))
        {
            tcs.SetResult(result);
        }
    }
}
