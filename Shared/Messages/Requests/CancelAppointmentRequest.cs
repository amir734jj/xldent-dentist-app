using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Requests;

public sealed class CancelAppointmentRequest : IAgentRequest
{
    public string EventId { get; set; } = string.Empty;
    public AgentRequestType RequestType
    {
        get { return AgentRequestType.CancelAppointment; }
    }
}
