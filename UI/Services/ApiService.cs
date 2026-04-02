using Refit;
using Shared.Contracts;
using Shared.Messages.Requests;

namespace UI.Services;

public sealed class ApiService(IAuthApi authApi, IAgentsApi agentsApi, IAgentKeysApi agentKeysApi, AuthService auth)
{
    public async Task<bool> LoginAsync(string email, string password)
    {
        try
        {
            var response = await authApi.LoginAsync(new LoginRequest(email, password));
            auth.SetToken(response.Token);
            return true;
        }
        catch (ApiException) { return false; }
    }

    public async Task<bool> RegisterAsync(string email, string password)
    {
        try
        {
            await authApi.RegisterAsync(new RegisterRequest(email, password));
            return true;
        }
        catch (ApiException) { return false; }
    }

    public Task<List<string>> GetAgentsAsync() => agentsApi.GetAgentsAsync();

    public Task<string?> SearchAppointmentsAsync(string agentId, SearchAppointmentsRequest request)
        => agentsApi.SearchAppointmentsAsync(agentId, request)!;

    public Task<string?> CancelAppointmentAsync(string agentId, string eventId)
        => agentsApi.CancelAppointmentAsync(agentId, new Shared.Contracts.CancelAppointmentRequest(eventId))!;

    // Agent key management
    public Task<List<AgentKeyDto>> GetAgentKeysAsync() => agentKeysApi.GetAllAsync();

    public Task<AgentKeyDto> CreateAgentKeyAsync(string agentId, string clinicName)
        => agentKeysApi.CreateAsync(new CreateAgentKeyRequest(agentId, clinicName));

    public Task DeleteAgentKeyAsync(string agentId) => agentKeysApi.DeleteAsync(agentId);
}
