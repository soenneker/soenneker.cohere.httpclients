using Soenneker.Cohere.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cohere.HttpClients.Tests;

[Collection("Collection")]
public sealed class CohereOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ICohereOpenApiHttpClient _httpclient;

    public CohereOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ICohereOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
