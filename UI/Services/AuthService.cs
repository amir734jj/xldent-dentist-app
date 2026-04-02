using Blazored.LocalStorage;
using Shared;

namespace UI.Services;

public sealed class AuthService(ILocalStorageService storage)
{
    private const string TokenKey = "auth_token";
    private const string RoleKey  = "auth_role";

    public string? Token { get; private set; }
    public string? Role  { get; private set; }
    public bool IsAuthenticated => Token is not null;
    public bool IsAdmin => Role == Roles.Admin;

    public async Task InitAsync()
    {
        Token = await storage.GetItemAsync<string>(TokenKey);
        Role  = await storage.GetItemAsync<string>(RoleKey);
    }

    public async Task SetTokenAsync(string token, string role)
    {
        Token = token;
        Role  = role;
        await storage.SetItemAsync(TokenKey, token);
        await storage.SetItemAsync(RoleKey, role);
    }

    public async Task ClearTokenAsync()
    {
        Token = null;
        Role  = null;
        await storage.RemoveItemAsync(TokenKey);
        await storage.RemoveItemAsync(RoleKey);
    }
}
