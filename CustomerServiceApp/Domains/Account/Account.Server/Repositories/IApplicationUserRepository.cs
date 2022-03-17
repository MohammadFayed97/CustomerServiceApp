namespace Account.Server.Repositories;

public interface IApplicationUserRepository
{
    Task<IdentityResult> RegisterUser(UserForRegisterViewModel userForRegister);
    Task<bool> ValidateUser(UserForLoginViewModel userForLogin);
    Task<AppUser> GetUserByUserName(string userName);
    Task UpdateUser(AppUser user);
}
