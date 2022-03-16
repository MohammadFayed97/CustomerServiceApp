namespace Account.Client.AuthServices;

public interface IAuthenticationService
{
    Task<RegisterUserResponse> CreateUser(UserForRegisterViewModel userForRegister);
    Task<AuthResponseViewModel> Login(UserForLoginViewModel userForLogin);
    Task Logout();
}
