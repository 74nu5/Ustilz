namespace Ustilz.AspNetCore;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Hosting;

/// <summary>Classe of <see cref="IWebHostBuilder" /> extensions.</summary>
[PublicAPI]
public static class WebHostBuilderExtensions
{
    /// <summary>Method that enable acces of website / api on free random port and any domain.</summary>
    /// <param name="webHostBuilder">The web host builder.</param>
    /// <returns>Returns the web host builder.</returns>
    public static IWebHostBuilder UseAnyDomainFreeRandomPort(this IWebHostBuilder webHostBuilder)
    {
        webHostBuilder.UseUrls("http://*:0", "https://*:0");
        return webHostBuilder;
    }

    /// <summary>Method that enable acces of website / api on free random port and defined domain.</summary>
    /// <param name="webHostBuilder">The web host builder.</param>
    /// <param name="listenDomain">Domain to listen.</param>
    /// <returns>Returns the web host builder.</returns>
    public static IWebHostBuilder UseFreeRandomPort(this IWebHostBuilder webHostBuilder, string listenDomain)
    {
        webHostBuilder.UseUrls($"http://{listenDomain}:0", $"https://{listenDomain}:0");
        return webHostBuilder;
    }

    /// <summary>Method that enable acces of website / api on free random port and and defined http / https domain.</summary>
    /// <param name="webHostBuilder">The web host builder.</param>
    /// <param name="httpListenDomain">Http domain to listen.</param>
    /// <param name="httpsListenDomain">Https domain to listen.</param>
    /// <returns>Returns the web host builder.</returns>
    public static IWebHostBuilder UseFreeRandomPort(this IWebHostBuilder webHostBuilder, string httpListenDomain, string httpsListenDomain)
    {
        webHostBuilder.UseUrls($"http://{httpListenDomain}:0", $"https://{httpsListenDomain}:0");
        return webHostBuilder;
    }

    /// <summary>Method that enable acces of website / api on free random port and any domain.</summary>
    /// <param name="webHostBuilder">The web host builder.</param>
    /// <returns>Returns the web host builder.</returns>
    public static IWebHostBuilder UseLocalhostFreeRandomPort(this IWebHostBuilder webHostBuilder)
    {
        webHostBuilder.UseUrls("http://[::1]:0", "https://[::1]:0");
        return webHostBuilder;
    }
}