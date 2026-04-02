using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class HealthResponse : IAgentResponse
{
    public bool DbConnected { get; set; }
    public DateTimeOffset? CheckedAt { get; set; }
    public AgentResponseType ResponseType
    {
        get { return AgentResponseType.Health; }
    }
}
