﻿namespace Account.Server.TokenServices;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user);
    JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, IEnumerable<Claim> claims);
    Task<IEnumerable<Claim>> GetClaims(AppUser user);
    SigningCredentials GetSigningCredentials();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    string GenerateRefreshToken();
}
