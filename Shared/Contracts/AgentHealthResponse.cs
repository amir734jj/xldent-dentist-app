namespace Shared.Contracts;

public record AgentHealthResponse(
    string AgentId,
    AgentStatus Status,
    DateTimeOffset? LastSeen,
    bool DbConnected,
    string? Version,
    DateTimeOffset? UpdatedAt,
    DateTimeOffset? StartedAt);
