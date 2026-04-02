using Shared.Appointments;
using Shared.Messages.Enums;
using Shared.Messages.Interfaces;

namespace Shared.Messages.Requests;

public sealed class SearchAppointmentsRequest : PatientSearchParams, IAgentRequest
{
    public AgentRequestType RequestType
    {
        get { return AgentRequestType.SearchAppointments; }
    }
}
