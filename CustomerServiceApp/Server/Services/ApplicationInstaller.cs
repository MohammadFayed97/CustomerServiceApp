namespace AppSquereTask.Server.Services;

using AppSquare.Shared.AssemplyScanning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using AutoMapper;

public class ApplicationInstaller : IInstaller
{
    private const string _myAllowSpecificOrigins = "_myAllowSpecificOrigins";

    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllersWithViews();
        services.AddRazorPages();

        services.AddCors(options =>
        {
            options.AddPolicy(_myAllowSpecificOrigins, builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo { Title = "CustomerServiceApp", Version = "v1" });
        });
        services.AddAutoMapper(config =>
        {
            config.AllowNullCollections = true;
        } , typeof(Program).Assembly);
    }
}
