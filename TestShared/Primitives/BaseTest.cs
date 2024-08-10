using Api.Setup.Application;

using CleanArchi.Domain.Entities.Primitives;
using CleanArchi.Infrastructure;
using CleanArchi.Presentation;

using System.Reflection;

namespace CleanArchi.ArchitectureTests.Primitives;

public abstract class BaseTest
{
    protected static readonly Assembly DomainAssembly = typeof(AuditableEntity).Assembly;
    protected static readonly Assembly ApplicationAssembly = typeof(ApplicationDependencyInjection).Assembly;
    protected static readonly Assembly InfrastructureAssembly = typeof(InfrastructureDependencyInjection).Assembly;
    protected static readonly Assembly PresentationAssembly = typeof(PresentationDependencyInjection).Assembly;
}

