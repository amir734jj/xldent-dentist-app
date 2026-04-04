using Refit;
using Shared.Appointments;
using Shared.Messages.Requests;

namespace Shared.Contracts.Interfaces;

[Headers("Authorization: Bearer")]
public interface IAgentsApi
{
    [Get("/api/agents")]
    Task<List<string>> GetAgentsAsync();

    [Post("/api/agents/{agentId}/search")]
    Task<List<PatientAppointmentResult>> SearchAppointmentsAsync(string agentId, [Body] SearchAppointmentsRequest request);

    [Get("/api/agents/{agentId}/health")]
    Task<AgentHealthResponse> GetHealthAsync(string agentId);

    [Post("/api/agents/{agentId}/cancel-appointment")]
    Task<string> CancelAppointmentAsync(string agentId, [Body] CancelAppointmentRequest request);
}
