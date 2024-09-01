namespace Ustilz.Http;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;

/// <summary>
///     Static class which contains extensions for <see cref="HttpService" />.
/// </summary>
[PublicAPI]
public static class HttpServiceExtension
{
    /// <summary>
    ///     The add ustilz http.
    /// </summary>
    /// <param name="services">The services collection.</param>
    /// <returns>The <see cref="IServiceCollection" />.</returns>
    public static IServiceCollection AddUstilzHttp(this IServiceCollection services)
    {
        services.AddHttpClient(HttpService.HttpClientName)
                .ConfigurePrimaryHttpMessageHandler(
                     () =>
                     {
                         var httpMessageHandler = new HttpClientHandler();
                         httpMessageHandler.ServerCertificateCustomValidationCallback += (_, _, _, _) => true;
                         return httpMessageHandler;
                     });

        services.AddTransient<HttpService>();
        return services;
    }
}
