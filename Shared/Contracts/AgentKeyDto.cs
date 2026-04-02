namespace Shared.Contracts;

public record AgentKeyDto(
    string AgentId,
    string ClinicName,
    Guid ApiKey,
    DateTimeOffset CreatedAt);

public record CreateAgentKeyRequest(string AgentId, string ClinicName);
