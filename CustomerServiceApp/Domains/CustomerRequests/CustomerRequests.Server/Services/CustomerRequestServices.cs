namespace CustomerRequests.Server.Services;

public class CustomerRequestServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<CustomerRequestViewModel>, CustomerRequestValidator>();
        services.AddScoped<ICustomerRequestRepository, CustomerRequestRepository>();
        services.AddScoped<ICustomerRequestUnitOfWork, CustomerRequestUnitOfWork>();
    }
}
