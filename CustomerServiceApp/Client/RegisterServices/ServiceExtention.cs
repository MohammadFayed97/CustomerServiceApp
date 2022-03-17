namespace CustomerServiceApp.Client;

using Account.Client.AuthServices;
using Account.Shared.Validations;
using Account.Shared.ViewModels;
using AppSquare.Shared.Client;
using AppSquare.Shared.Client.HttpServices;
using Blazored.LocalStorage;
using Cities.Shared.Validations;
using Cities.Shared.ViewModels;
using CustomerRequests.Shared.Validations;
using CustomerRequests.Shared.ViewModels;
using Customers.Shared.Validations;
using Customers.Shared.ViewModels;
using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Services.Shared.Validations;
using Services.Shared.ViewModels;

public static class ServiceExtention
{
    public static void ConfigureFluentValidationServices(this IServiceCollection services)
    {
        services.AddScoped<IValidator<UserForLoginViewModel>, UserForLoginValidator>();
        services.AddScoped<IValidator<UserForRegisterViewModel>, UserForRegisterValidator>();
        services.AddScoped<IValidator<CityViewModel>, CityValidator>();
        services.AddScoped<IValidator<ServiceViewModel>, ServiceValidator>();
        services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
        services.AddScoped<IValidator<CustomerRequestViewModel>, CustomerRequestValidator>();
    }
    public static void ConfigureAuthentication(this IServiceCollection services, IWebAssemblyHostEnvironment hostEnvironment)
    {

        services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(hostEnvironment.BaseAddress) });
        services.AddAuthorizationCore();
        services.AddBlazoredLocalStorage();
        services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
    public static void ConfigureHttpServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IHttpService<>), typeof(HttpService<>));
    }
}
