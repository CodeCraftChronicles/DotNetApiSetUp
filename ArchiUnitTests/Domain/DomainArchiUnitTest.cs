using ArchiUnitTests;

using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;

using Xunit;

namespace ArchiUnitTests.Domain
{
    public sealed class DomainArchiUnitTest : ArchitectureUnitBaseTest
    {
        [Fact]
        public void DomainShouldNotHaveDependencyOnApplicatioLayer()
        {
            ArchRuleDefinition.Classes().That().Are(DomaineLayer).Should().NotDependOnAny(ApplicationLayer).Check(OurArchitecture);
        }

    }
}
