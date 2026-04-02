namespace UI.Services;

public sealed class AuthService
{
    public string? Token { get; private set; }
    public bool IsAuthenticated => Token is not null;

    public void SetToken(string token)
    {
        Token = token;
    }

    public void ClearToken()
    {
        Token = null;
    }
}
