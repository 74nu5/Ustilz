namespace Ustilz.Api.Minimal.Modules;

using System.Reflection;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
///     Provides extension methods to work with <seealso cref="IModule" />.
/// </summary>
[PublicAPI]
public static class ModuleExtension
{
    /// <summary>
    ///     Registers all modules of this project that implements <seealso cref="IModule" />.
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>Returns the service collection</returns>
    public static IServiceCollection RegisterModulesServices(this IServiceCollection services)
    {
        var modules = DiscoverModules();

        foreach (var module in modules)
        {
            services.AddTransient(typeof(IModule), module);
        }

        return services.RegisterModulesDependencies();
    }

    /// <summary>
    ///     Adds route endpoints for all modules.
    /// </summary>
    /// <param name="endpoints">The endpoint route builder</param>
    /// <returns>The endpoint route builder</returns>
    public static IEndpointRouteBuilder MapModulesEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var modules = GetRegisteredModules(endpoints.ServiceProvider);

        foreach (var module in modules)
        {
            module.MapEndpoints(endpoints);
        }

        return endpoints;
    }

    public static IApplicationBuilder UseModuleBuildActions(this IApplicationBuilder app)
    {
        var modules = app.ApplicationServices.GetServices<IModule>();
        foreach (var module in modules)
        {
            module.ConfigureModule(app.ApplicationServices);
        }

        return app;
    }

    /// <summary>
    ///     Registers all modules dependencies.
    /// </summary>
    /// <param name="services">The services collection</param>
    /// <returns>Returns the service collection.</returns>
    private static IServiceCollection RegisterModulesDependencies(this IServiceCollection services)
    {
        var modules = GetRegisteredModules(services.BuildServiceProvider());
        var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

        foreach (var module in modules)
        {
            module.RegisterModule(services, configuration);
        }

        return services;
    }

    /// <summary>
    ///     Returns the collection of modules declared in this project.
    /// </summary>
    /// <returns>
    ///     Returns a module collection.
    /// </returns>
    private static IEnumerable<Type> DiscoverModules(Assembly? assembly = null)
    {
        var assemblies = assembly ?? Assembly.GetEntryAssembly() ?? typeof(IModule).Assembly;
        return assemblies.GetTypes().Where(p => p.IsClass && p.IsAssignableTo(typeof(IModule)));
    }

    /// <summary>
    ///     Returns all modules instances.
    /// </summary>
    /// <param name="provider">The service provider.</param>
    /// <returns>Return a collection of <seealso cref="IModule" /> instances.</returns>
    private static IEnumerable<IModule> GetRegisteredModules(IServiceProvider provider)
        => provider.GetServices<IModule>();
}
