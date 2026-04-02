using Refit;

namespace Shared.Contracts;

public interface IAuthApi
{
    [Post("/api/auth/login")]
    Task<LoginResponse> LoginAsync([Body] LoginRequest request);

    [Post("/api/auth/register")]
    Task RegisterAsync([Body] RegisterRequest request);
}