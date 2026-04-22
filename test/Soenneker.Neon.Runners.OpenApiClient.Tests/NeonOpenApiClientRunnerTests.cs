using Soenneker.Tests.HostedUnit;

namespace Soenneker.Neon.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NeonOpenApiClientRunnerTests : HostedUnitTest
{
    public NeonOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
