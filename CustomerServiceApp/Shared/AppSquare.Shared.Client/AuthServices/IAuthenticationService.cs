namespace AppSquare.Shared.Client.AuthServices;

public interface IAuthenticationService
{
    Task<RegisterUserResponse> CreateUser(string url, UserForRegisterViewModel userForRegister);
    Task<AuthResponseViewModel> Login(string url, UserForLoginViewModel userForLogin);
    Task Logout();
    Task<string> RefreshToken(string url);
}
