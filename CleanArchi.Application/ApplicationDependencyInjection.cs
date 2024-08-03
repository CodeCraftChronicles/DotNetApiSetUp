using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace Api.Setup.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection RegisterApplicationLayer(this IServiceCollection services)
    {
        Assembly assembly = typeof(ApplicationDependencyInjection).Assembly;
        return services.AddMediatR(config=>config.RegisterServicesFromAssembly(assembly));

    }
}
