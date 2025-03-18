using Microsoft.Extensions.Hosting;
using Shopware6.StoreApi.Generated;

namespace Shopware6.StoreApi;

/// <summary>
/// <see cref="IHostApplicationBuilder"/> Extensions
/// </summary>
public static class AppBuilderExtensions
{
    /// <summary>
    /// Initializes the Shopware 6 Store API Client
    /// </summary>
    /// <param name="builder"><see cref="IHostApplicationBuilder"/></param>
    /// <param name="baseUrl">BeseUrl of Shopware</param>
    /// <returns><see cref="IHostApplicationBuilder"/> initialized for <see cref="Shopware6.StoreApi"/></returns>
    public static IHostApplicationBuilder UseShopwareStoreApi(this IHostApplicationBuilder builder, string baseUrl)
    {
        var baseUri = new Uri(baseUrl);
        builder.Services.ConfigureRefitClients(baseUrl: baseUri);
        return builder;
    }
}