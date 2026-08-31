[![](https://img.shields.io/nuget/v/soenneker.cohere.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cohere.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cohere.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cohere.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cohere.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cohere.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cohere.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cohere.httpclients/actions/workflows/codeql.yml)

# Soenneker.Cohere.HttpClients

Provides an owned, bearer-authenticated `HttpClient` for Cohere's generated OpenAPI client.

## Installation

```bash
dotnet add package Soenneker.Cohere.HttpClients
```

## Configuration

```json
{
  "Cohere": {
    "ApiKey": "your-api-key",
    "ClientBaseUrl": "https://api.cohere.com",
    "AuthHeaderName": "Authorization",
    "AuthHeaderValueTemplate": "Bearer {token}"
  }
}
```

`ApiKey` is required. The other values show their defaults. `{token}` is replaced with the configured key. Keep the credential in a secret provider.

## Registration and usage

```csharp
using Soenneker.Cohere.HttpClients.Abstract;
using Soenneker.Cohere.HttpClients.Registrars;

services.AddCohereOpenApiHttpClientAsSingleton();

HttpClient httpClient = await clientProvider.Get(cancellationToken);
```

`Get` returns the same configured client for the provider's lifetime. `Soenneker.Cohere.OpenApiClientUtil` is the normal entry point for typed Cohere operations.

The provider owns its cache entry. Do not dispose the returned `HttpClient` directly. Let dependency injection dispose `ICohereOpenApiHttpClient`, which removes and disposes the client. Scoped providers use isolated cache entries, so one scope cannot tear down another provider's client.
