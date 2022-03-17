namespace AppSquare.Shared.Client.AuthServices;

public interface IRefreshTokenService
{
    Task<string> TryRefreshToken(string refreshTokenUrl);
}
