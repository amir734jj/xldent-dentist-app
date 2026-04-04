using Refit;
using Shared.Appointments;
using Shared.Contracts;
using Shared.Contracts.Interfaces;
using Shared.Messages.Requests;

namespace UI.Services;

public sealed class ApiService(IAuthApi authApi, IAgentsApi agentsApi, IAgentKeysApi agentKeysApi, IUsersApi usersApi, IProfileApi profileApi, AuthService auth)
{
    // Returns null on success, or an error message string.
    public async Task<string?> LoginAsync(string email, string password)
    {
        try
        {
            var response = await authApi.LoginAsync(new LoginRequest(email, password));
            await auth.SetTokenAsync(response.Token, response.Role, response.UserId);
            // Fetch display name now that we have a token
            try
            {
                var me = await authApi.MeAsync();
                await auth.SetDisplayNameAsync(me.DisplayName);
            }
            catch { /* non-critical */ }
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

    public Task<List<string>> GetAgentsAsync()
    {
        return agentsApi.GetAgentsAsync();
    }

    public Task<AgentHealthResponse> GetAgentHealthAsync(string agentId)
    {
        return agentsApi.GetHealthAsync(agentId);
    }

    public Task<List<PatientAppointmentResult>> SearchAppointmentsAsync(string agentId, SearchAppointmentsRequest request)
    {
        return agentsApi.SearchAppointmentsAsync(agentId, request);
    }

    public Task<string?> CancelAppointmentAsync(string agentId, string eventId)
    {
        return agentsApi.CancelAppointmentAsync(agentId, new Shared.Contracts.CancelAppointmentRequest(eventId))!;
    }

    // Agent key management
    public Task<List<AgentKeyDto>> GetAgentKeysAsync()
    {
        return agentKeysApi.GetAllAsync();
    }

    public Task<AgentKeyDto> CreateAgentKeyAsync(string agentId)
    {
        return agentKeysApi.CreateAsync(new CreateAgentKeyRequest(agentId));
    }

    public Task DeleteAgentKeyAsync(string agentId)
    {
        return agentKeysApi.DeleteAsync(agentId);
    }

    // User management (Admin only)
    public Task<List<UserDto>> GetUsersAsync()
    {
        return usersApi.GetAllAsync();
    }

    public Task ActivateUserAsync(Guid id)
    {
        return usersApi.ActivateAsync(id);
    }

    public Task DeactivateUserAsync(Guid id)
    {
        return usersApi.DeactivateAsync(id);
    }

    public Task DeleteUserAsync(Guid id)
    {
        return usersApi.DeleteAsync(id);
    }

    public Task MakeAdminAsync(Guid id)
    {
        return usersApi.MakeAdminAsync(id);
    }

    public Task MakeUserAsync(Guid id)
    {
        return usersApi.MakeUserAsync(id);
    }

    // Profile
    public Task<MeResponse> GetProfileAsync()
    {
        return authApi.MeAsync();
    }

    public async Task UpdateProfileAsync(string? displayName)
    {
        await profileApi.UpdateAsync(new UpdateProfileRequest(displayName));
        await auth.SetDisplayNameAsync(displayName);
    }

    public Task ChangePasswordAsync(string currentPassword, string newPassword, string newPasswordConfirm)
    {
        return profileApi.ChangePasswordAsync(new ChangePasswordRequest(currentPassword, newPassword, newPasswordConfirm));
    }
}
