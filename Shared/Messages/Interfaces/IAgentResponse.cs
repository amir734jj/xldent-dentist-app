using JsonSubTypes;
using Newtonsoft.Json;
using Shared.Messages.Enums;
using Shared.Messages.Responses;

namespace Shared.Messages.Interfaces;

[JsonConverter(typeof(JsonSubtypes), nameof(ResponseType))]
[JsonSubtypes.KnownSubType(typeof(HealthResponse), AgentResponseType.Health)]
[JsonSubtypes.KnownSubType(typeof(AppointmentsResponse), AgentResponseType.Appointments)]
[JsonSubtypes.KnownSubType(typeof(SuccessResponse), AgentResponseType.Success)]
[JsonSubtypes.KnownSubType(typeof(AgentErrorResponse), AgentResponseType.Error)]
public interface IAgentResponse
{
    AgentResponseType ResponseType { get; }
}
