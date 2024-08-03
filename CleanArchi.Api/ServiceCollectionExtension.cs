using Api.Setup.Application;

using CleanArchi.Infrastructure;
using CleanArchi.Presentation;

namespace Api;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCleanArchiLayers(this IServiceCollection services) =>
        services.RegisterApplicationLayer()
        .RegisterInfrastructureLayer()
        .RegisterPresentationLayer();   
}
