namespace Account.Server.TokenServices;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user, IEnumerable<string> roles);
    JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, IEnumerable<Claim> claims);
    Task<IEnumerable<Claim>> GetClaims(AppUser user, IEnumerable<string> roles);
    SigningCredentials GetSigningCredentials();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    string GenerateRefreshToken();
}
