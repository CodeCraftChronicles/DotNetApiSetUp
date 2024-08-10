using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;

using Xunit;

namespace CleanArchi.ArchitectureTests.Domain
{
    public sealed class DomainArchiUnitTest: ArchitectureUnitBaseTest
    {
        [Fact]
        public void DomainShouldNotHaveDependencyOnApplicatioLayer()
        {
            ArchRuleDefinition.Classes().That().Are(DomaineLayer).Should().NotDependOnAny(ApplicationLayer).Check(OurArchitecture);
        }

    }
}
