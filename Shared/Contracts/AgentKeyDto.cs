namespace Shared.Contracts;

public record AgentKeyDto(
    string AgentId,
    Guid ApiKey,
    DateTimeOffset CreatedAt);
