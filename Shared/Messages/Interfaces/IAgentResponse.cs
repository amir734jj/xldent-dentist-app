using System.Text.Json.Serialization;
using Shared.Messages.Responses;

namespace Shared.Messages.Interfaces;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(HealthResponse), "Health")]
[JsonDerivedType(typeof(AppointmentsResponse), "Appointments")]
[JsonDerivedType(typeof(SuccessResponse), "Success")]
[JsonDerivedType(typeof(AgentErrorResponse), "Error")]
public interface IAgentResponse
{
    string ResponseType { get; }
}
