namespace Account.Server.AuthenticationManagers;

public class AuthenticationManager : IAuthenticationManager
{
    private readonly UserManager<AppUser> _userManager;
    private readonly JwtConfiguration _jwtConfiguration;
    private AppUser _user;
    public AuthenticationManager(UserManager<AppUser> userManager, JwtConfiguration jwtConfiguration)
    {
        _userManager = userManager;
        _jwtConfiguration = jwtConfiguration;
    }
    public async Task<bool> ValidateUser(UserForLoginViewModel userForLogin)
    {
        _user = await _userManager.FindByNameAsync(userForLogin.UserName);

        return (_user != null && await _userManager.CheckPasswordAsync(_user, userForLogin.Password));
    }

    public async Task<string> CreateToken()
    {
        var signingCredential = GetSigningCredentials();
        var claims = await GetClaims();
        var tokenOptions = GenerateTokenOptions(signingCredential, claims);

        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    private SigningCredentials GetSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(_jwtConfiguration.Key);
        var secret = new SymmetricSecurityKey(key);
        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }

    private async Task<IEnumerable<Claim>> GetClaims()
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, _user.UserName)
        };

        foreach (var role in await _userManager.GetRolesAsync(_user))
        {
            if (string.IsNullOrEmpty(role))
                continue;

            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        return claims;
    }

    private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, IEnumerable<Claim> claims)
    {
        return new JwtSecurityToken
        (
            issuer: _jwtConfiguration.Issuer,
            audience: _jwtConfiguration.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtConfiguration.DurationInMinutes)),
            signingCredentials: signingCredentials
        );
    }
}
