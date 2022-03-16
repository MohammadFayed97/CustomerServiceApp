namespace Cities.Server.Services;

public class CityServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<CityViewModel>, CityValidator>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICityUnitOfWork, CityUnitOfWork>();
    }
}
