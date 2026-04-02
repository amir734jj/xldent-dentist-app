using Shared.Appointments;
using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Responses;

public sealed class AppointmentsResponse : IAgentResponse
{
    public IReadOnlyList<PatientAppointmentResult> Data { get; set; } = [];
    public AgentResponseType ResponseType => AgentResponseType.Appointments;
}
