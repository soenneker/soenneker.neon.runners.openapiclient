using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Neon.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NeonOpenApiClientRunnerTests : FixturedUnitTest
{
    public NeonOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
