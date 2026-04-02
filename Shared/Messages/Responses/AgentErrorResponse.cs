using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class AgentErrorResponse : IAgentResponse
{
    public string Message { get; set; } = string.Empty;
    public AgentResponseType ResponseType
    {
        get { return AgentResponseType.Error; }
    }
}
