using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class AppointmentsResponse : IAgentResponse
{
    public string Data { get; set; } = string.Empty;
    public string ResponseType => AgentResponseType.Appointments;
}
