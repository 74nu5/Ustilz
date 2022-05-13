namespace Ustilz.Api.Minimal.Modules;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
///     Defines methods to be implemented by a module.
/// </summary>
[PublicAPI]
public interface IModule
{
    /// <summary>
    ///     Registers the module depedencies.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">The configuration service manager.</param>
    /// <returns>
    ///     The service collection with all dependencies added.
    /// </returns>
    void RegisterModule(IServiceCollection services, IConfiguration configuration)
    {
    }

    /// <summary>
    ///     Configure module dependencies once service provider has been built.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    void ConfigureModule(IServiceProvider serviceProvider)
    {
    }

    /// <summary>
    ///     Maps incoming requests to the specified services types declared by the module.
    /// </summary>
    /// <param name="endpoints">The route builder.</param>
    void MapEndpoints(IEndpointRouteBuilder endpoints);
}
