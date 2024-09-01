namespace Ustilz.Parsers.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Ustilz.Parsers.Csv;
using Ustilz.Parsers.Csv.Abstractions;

/// <summary>
///     Provides extension methods to work with parsers.
/// </summary>
public static class ParsersExtension
{
    /// <summary>
    ///     Adds parsers to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddParsers(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.TryAddTransient<IMethodsParseProvider, MethodsParseProvider>();

        return services;
    }
}
