namespace CustomerServiceApp.Client;

using Account.Client.AuthServices;
using Account.Shared.Validations;
using Account.Shared.ViewModels;
using AppSquare.Shared.Client;
using Blazored.LocalStorage;
using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

public static class ServiceExtention
{
    public static void ConfigureFluentValidationServices(this IServiceCollection services)
    {
        services.AddScoped<IValidator<UserForLoginViewModel>, UserForLoginValidator>();
        services.AddScoped<IValidator<UserForRegisterViewModel>, UserForRegisterValidator>();
    }
    public static void ConfigureAuthentication(this IServiceCollection services, IWebAssemblyHostEnvironment hostEnvironment)
    {

        services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(hostEnvironment.BaseAddress) });
        services.AddAuthorizationCore();
        services.AddBlazoredLocalStorage();
        services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}
