namespace Ustilz.Parsers.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Ustilz.Parsers.Csv;
using Ustilz.Parsers.Csv.Abstractions;

public static class ParsersExtension
{
    public static IServiceCollection AddParsers(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.TryAddTransient<IMethodsParseProvider, MethodsParseProvider>();

        return services;
    }
}
