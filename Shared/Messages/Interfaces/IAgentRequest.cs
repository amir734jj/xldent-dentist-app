using JsonSubTypes;
using Newtonsoft.Json;
using Shared.Messages.Enums;
using Shared.Messages.Requests;

namespace Shared.Messages.Interfaces;

[JsonConverter(typeof(JsonSubtypes), "RequestType")]
[JsonSubtypes.KnownSubType(typeof(GetHealthRequest), AgentRequestType.GetHealth)]
[JsonSubtypes.KnownSubType(typeof(SearchAppointmentsRequest), AgentRequestType.SearchAppointments)]
[JsonSubtypes.KnownSubType(typeof(CancelAppointmentRequest), AgentRequestType.CancelAppointment)]
public interface IAgentRequest
{
    AgentRequestType RequestType { get; }
}
