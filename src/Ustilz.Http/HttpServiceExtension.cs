namespace Ustilz.Http;

using System.Net.Http;

using Microsoft.Extensions.DependencyInjection;

public static class HttpServiceExtension
{
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