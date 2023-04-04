namespace Kwtc.ErrorMonitoring.Ui.Application;

using Abstractions.Api;
using Abstractions.Auth;
using Api;
using Auth;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services
            .AddMediatR(config =>
                config.RegisterServicesFromAssembly(typeof(ServiceCollectionExtensions).Assembly));

        services.AddScoped<IApiClient, ApiClient>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
