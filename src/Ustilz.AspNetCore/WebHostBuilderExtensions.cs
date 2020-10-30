namespace Ustilz.AspNetCore
{
    #region Usings

    using Microsoft.AspNetCore.Hosting;

    #endregion

    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseAnyDomainFreeRandomPort(this IWebHostBuilder webHostBuilder)
        {
            webHostBuilder.UseUrls("http://*:0", "https://*:0");
            return webHostBuilder;
        }

        public static IWebHostBuilder UseFreeRandomPort(this IWebHostBuilder webHostBuilder, string listenDomain)
        {
            webHostBuilder.UseUrls($"http://{listenDomain}:0", $"https://{listenDomain}:0");
            return webHostBuilder;
        }

        public static IWebHostBuilder UseFreeRandomPort(this IWebHostBuilder webHostBuilder, string httpListenDomain, string httpsListenDomain)
        {
            webHostBuilder.UseUrls($"http://{httpListenDomain}:0", $"https://{httpsListenDomain}:0");
            return webHostBuilder;
        }

        public static IWebHostBuilder UseLocalhostFreeRandomPort(this IWebHostBuilder webHostBuilder)
        {
            webHostBuilder.UseUrls("http://[::1]:0", "https://[::1]:0");
            return webHostBuilder;
        }
    }
}
