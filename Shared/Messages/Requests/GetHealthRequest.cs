using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Requests;

public sealed class GetHealthRequest : IAgentRequest
{
    public AgentRequestType RequestType
    {
        get { return AgentRequestType.GetHealth; }
    }
}
