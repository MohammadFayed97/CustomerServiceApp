namespace AppSquereTask.Server.Services;

using AppSquare.Shared.AssemplyScanning;
using AppSquare.Shared.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class DbContextInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("DefualtConnection"), builder => builder.MigrationsAssembly(typeof(Program).Assembly.FullName))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
        });
    }
}
