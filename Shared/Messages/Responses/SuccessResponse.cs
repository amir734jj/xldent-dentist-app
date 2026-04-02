using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class SuccessResponse : IAgentResponse
{
    public string Value { get; set; } = string.Empty;
    public AgentResponseType ResponseType => AgentResponseType.Success;
}
