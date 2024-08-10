using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;

using CleanArchi.ArchitectureTests.Primitives;

namespace ArchiUnitTests;

public abstract class ArchitectureUnitBaseTest : BaseTest
{
    protected static readonly Architecture OurArchitecture = new ArchLoader().LoadAssemblies(
        DomainAssembly,
        ApplicationAssembly,
        InfrastructureAssembly,
        PresentationAssembly).Build();

    protected static readonly IObjectProvider<IType> DomaineLayer = ArchRuleDefinition.Types().That().ResideInAssembly(DomainAssembly).As("Domain Layer");
    protected static readonly IObjectProvider<IType> ApplicationLayer = ArchRuleDefinition.Types().That().ResideInAssembly(ApplicationAssembly).As("Application Layer");
    protected static readonly IObjectProvider<IType> InfrastructureLayer = ArchRuleDefinition.Types().That().ResideInAssembly(InfrastructureAssembly).As("Infrastructure Layer");
    protected static readonly IObjectProvider<IType> PresentationLayer = ArchRuleDefinition.Types().That().ResideInAssembly(PresentationAssembly).As("Presentation Layer");

}
