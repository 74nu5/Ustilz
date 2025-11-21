namespace Ustilz.Http;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;

/// <summary>
///     Static class which contains extensions for <see cref="HttpService" />.
/// </summary>
[PublicAPI]
public static class HttpServiceExtension
{
    extension(IServiceCollection services)
    {
        /// <summary>
        ///     The add ustilz http.
        /// </summary>
        /// <returns>The <see cref="IServiceCollection" />.</returns>
        public IServiceCollection AddUstilzHttp()
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
}
