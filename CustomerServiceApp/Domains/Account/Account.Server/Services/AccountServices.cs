namespace Account.Server.Services;

public class AccountServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAuthenticationManager, AuthenticationManager>();
    }
}
