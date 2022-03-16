namespace Account.Server.Repositories;

public interface IApplicationUserRepository
{
    Task<IdentityResult> RegisterUser(UserForRegisterViewModel userForRegister);
}
