namespace Account.Server.Repositories;

public class ApplicationUserRepository : IApplicationUserRepository
{
    private readonly UserManager<AppUser> _userManager;
    public ApplicationUserRepository(UserManager<AppUser> userManager) => _userManager = userManager;

    public async Task<IdentityResult> RegisterUser(UserForRegisterViewModel userForRegister)
    {
        string userFullName = $"{userForRegister.FirstName} {userForRegister.LastName}";

        AppUser user = new AppUser
        {
            FullName = userFullName,
            UserName = userForRegister.UserName,
            PhoneNumber = userForRegister.PhoneNumber
        };

        return await _userManager.CreateAsync(user, userForRegister.Password);
    }
}
