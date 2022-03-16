namespace AppSquare.Shared;

public class CommonSharedServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddFluentValidation(e =>
        {
            e.AutomaticValidationEnabled = true;
        });
    }
}
