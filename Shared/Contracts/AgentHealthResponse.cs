namespace Shared.Contracts;

public record AgentHealthResponse(
    string AgentId,
    string Status,
    DateTimeOffset? LastSeen,
    bool DbConnected);
