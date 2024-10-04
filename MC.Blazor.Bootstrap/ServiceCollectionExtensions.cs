using Microsoft.Extensions.DependencyInjection;

namespace MC.Blazor.Bootstrap;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMC_Bootstrap(this IServiceCollection services)
    {
        // Add services and configurations that your library needs here
        // Example: services.AddScoped<MyService>();

        return services;
    }
}
