namespace Services.Server.Services;

using FluentValidation;
using global::Services.Shared.Validations;

public class ServiceServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<ServiceViewModel>, ServiceValidator>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IServiceUnitOfWork, ServiceUnitOfWork>();
    }
}
