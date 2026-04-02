using Blazored.LocalStorage;
using Shared;

namespace UI.Services;

public sealed class AuthService(ILocalStorageService storage)
{
    private const string TokenKey  = "auth_token";
    private const string RoleKey   = "auth_role";
    private const string UserIdKey = "auth_userid";

    public string? Token  { get; private set; }
    public string? Role   { get; private set; }
    public Guid?   UserId { get; private set; }

    public bool IsAuthenticated
    {
        get { return Token is not null; }
    }

    public bool IsAdmin
    {
        get { return Role == Roles.Admin; }
    }

    public async Task InitAsync()
    {
        Token  = await storage.GetItemAsync<string>(TokenKey);
        Role   = await storage.GetItemAsync<string>(RoleKey);
        UserId = await storage.GetItemAsync<Guid?>(UserIdKey);
    }

    public async Task SetTokenAsync(string token, string role, Guid userId)
    {
        Token  = token;
        Role   = role;
        UserId = userId;
        await storage.SetItemAsync(TokenKey,  token);
        await storage.SetItemAsync(RoleKey,   role);
        await storage.SetItemAsync(UserIdKey, userId);
    }

    public async Task ClearTokenAsync()
    {
        Token  = null;
        Role   = null;
        UserId = null;
        await storage.RemoveItemAsync(TokenKey);
        await storage.RemoveItemAsync(RoleKey);
        await storage.RemoveItemAsync(UserIdKey);
    }
}
