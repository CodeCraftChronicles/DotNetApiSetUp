using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace CleanArchi.Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection RegisterInfrastructureLayer(this IServiceCollection services)
    {
        Assembly assembly = typeof(InfrastructureDependencyInjection).Assembly;
        return services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

    }
}
