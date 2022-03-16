namespace Customers.Server.Services;

public class CustomerServices : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
    }
}
