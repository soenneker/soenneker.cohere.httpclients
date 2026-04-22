using Soenneker.Cohere.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cohere.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CohereOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ICohereOpenApiHttpClient _httpclient;

    public CohereOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ICohereOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
