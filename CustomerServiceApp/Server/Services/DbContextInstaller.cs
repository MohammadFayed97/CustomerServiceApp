namespace AppSquereTask.Server.Services;

using Account.Server.Entities;
using AppSquare.Shared.AssemplyScanning;
using AppSquare.Shared.Server;
using Microsoft.AspNetCore.Identity;
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

        IdentityBuilder builder = services.AddIdentityCore<AppUser>(options =>
        {
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 8;
        });

        builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);

        builder.AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
    }
}
