using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace CleanArchi.Presentation;

public static class PresentationDependencyInjection
{
    public static IServiceCollection RegisterPresentationLayer(this IServiceCollection services)
    {
        Assembly assembly = typeof(PresentationDependencyInjection).Assembly;
        return services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

    }
}

