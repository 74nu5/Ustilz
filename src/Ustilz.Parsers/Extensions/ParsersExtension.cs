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
    extension(IServiceCollection services)
    {
        /// <summary>
        ///     Adds parsers to the service collection.
        /// </summary>
        /// <returns>The service collection.</returns>
        public IServiceCollection AddParsers()
        {
            services.AddMemoryCache();
            services.TryAddTransient<IMethodsParseProvider, MethodsParseProvider>();

            return services;
        }
    }
}
