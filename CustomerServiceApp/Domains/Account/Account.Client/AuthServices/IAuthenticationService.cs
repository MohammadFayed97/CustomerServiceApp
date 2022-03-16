namespace Account.Client.AuthServices;

public interface IAuthenticationService
{
    Task<AuthResponseViewModel> Login(UserForLoginViewModel userForLogin);
}
