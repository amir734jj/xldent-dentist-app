using Refit;
using Shared.Contracts;
using Shared.Messages.Requests;

namespace UI.Services;

public sealed class ApiService(IAuthApi authApi, IAgentsApi agentsApi, IAgentKeysApi agentKeysApi, IUsersApi usersApi, AuthService auth)
{
    // Returns null on success, or an error message string.
    public async Task<string?> LoginAsync(string email, string password)
    {
        try
        {
            var response = await authApi.LoginAsync(new LoginRequest(email, password));
            await auth.SetTokenAsync(response.Token, response.Role);
            return null;
        }
        catch (ApiException ex) when ((int)ex.StatusCode == 403)
        {
            return "Your account is pending activation by an administrator.";
        }
        catch (ApiException)
        {
            return "Invalid email or password.";
        }
    }

    // Returns (success, isActive, errorMessage)
    public async Task<(bool Success, bool IsActive, string? Error)> RegisterAsync(string email, string password, string passwordConfirm)
    {
        try
        {
            var response = await authApi.RegisterAsync(new RegisterRequest(email, password, passwordConfirm));
            return (true, response.IsActive, null);
        }
        catch (ApiException)
        {
            return (false, false, "Registration failed. Password must be at least 8 characters.");
        }
    }

    public Task<List<string>> GetAgentsAsync() => agentsApi.GetAgentsAsync();

    public Task<string?> SearchAppointmentsAsync(string agentId, SearchAppointmentsRequest request)
        => agentsApi.SearchAppointmentsAsync(agentId, request)!;

    public Task<string?> CancelAppointmentAsync(string agentId, string eventId)
        => agentsApi.CancelAppointmentAsync(agentId, new Shared.Contracts.CancelAppointmentRequest(eventId))!;

    // Agent key management
    public Task<List<AgentKeyDto>> GetAgentKeysAsync() => agentKeysApi.GetAllAsync();

    public Task<AgentKeyDto> CreateAgentKeyAsync(string agentId)
        => agentKeysApi.CreateAsync(new CreateAgentKeyRequest(agentId));

    public Task DeleteAgentKeyAsync(string agentId) => agentKeysApi.DeleteAsync(agentId);

    // User management (Admin only)
    public Task<List<UserDto>> GetUsersAsync() => usersApi.GetAllAsync();
    public Task ActivateUserAsync(Guid id) => usersApi.ActivateAsync(id);
    public Task DeactivateUserAsync(Guid id) => usersApi.DeactivateAsync(id);
}
