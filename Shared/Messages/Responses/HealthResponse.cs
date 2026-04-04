using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class HealthResponse : IAgentResponse
{
    public bool DbConnected { get; set; }
    public DateTimeOffset? CheckedAt { get; set; }
    public DateTimeOffset? StartedAt { get; set; }
    public string? Version { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public AgentResponseType ResponseType => AgentResponseType.Health;
}
