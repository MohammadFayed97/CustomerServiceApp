namespace Account.Server.AuthenticationManagers;

public interface IAuthenticationManager
{
    Task<bool> ValidateUser(UserForLoginViewModel userForLogin);
    Task<string> CreateToken();
}
