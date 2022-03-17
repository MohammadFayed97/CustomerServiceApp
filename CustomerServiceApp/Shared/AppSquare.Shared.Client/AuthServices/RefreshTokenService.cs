namespace AppSquare.Shared.Client.AuthServices;

public class RefreshTokenService : IRefreshTokenService
{
    private readonly AuthenticationStateProvider _authProvider;
    private readonly IAuthenticationService _authService;
    public RefreshTokenService(AuthenticationStateProvider authProvider, IAuthenticationService authService)
    {
        _authProvider = authProvider;
        _authService = authService;
    }

    public async Task<string> TryRefreshToken(string refreshTokenUrl)
    {
        var authState = await _authProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        var exp = user.FindFirst(c => c.Type.Equals("exp"))?.Value;
        Console.WriteLine(exp);
        var expTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(exp));
        var timeUTC = DateTime.UtcNow;
        var diff = expTime - timeUTC;

        if (diff.TotalMinutes <= 2)
            return await _authService.RefreshToken(refreshTokenUrl);

        return string.Empty;
    }
}
