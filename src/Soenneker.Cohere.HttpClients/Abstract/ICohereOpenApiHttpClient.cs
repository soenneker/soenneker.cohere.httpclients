using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Cohere.HttpClients.Abstract;

/// <summary>
/// Provides an owned, configured <see cref="HttpClient"/> for Cohere's OpenAPI client.
/// </summary>
public interface ICohereOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the HTTP client owned by this provider instance.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
