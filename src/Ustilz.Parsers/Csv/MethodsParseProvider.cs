namespace Ustilz.Parsers.Csv;

using System.Globalization;
using System.Reflection;

using Microsoft.Extensions.Caching.Memory;

using Ustilz.Parsers.Csv.Abstractions;
using Ustilz.Parsers.Csv.Models;

internal sealed class MethodsParseProvider(IMemoryCache cache) : IMethodsParseProvider
{
    private const string DefautlParseMethodKey = "DefaultParseMethod";
    private const string FormatParseMethodKey = "FormatParseMethod";
    private const string ParseNumberMethodKey = "ParseNumberMethod";
    private const string FormatParseExactMethodKey = "FormatParseExactMethod";

    public void AddParseMethodsToCache(IEnumerable<CsvColumn> columns)
    {
        foreach (var column in columns)
        {
            var defaultParseMethod = GetParseMethod(column, BindingFlags.Public | BindingFlags.Static, typeof(string));
            var formatParseMethod = GetParseMethod(column, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(IFormatProvider));
            var parseNumberMethod = GetParseMethod(column, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(NumberStyles), typeof(IFormatProvider));
            var formatParseExactMethod = GetParseExactMethod(column, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(string), typeof(IFormatProvider));
            if (defaultParseMethod is not null)
                _ = cache.Set(DefautlParseMethodKey, defaultParseMethod);

            if (formatParseMethod is not null)
                _ = cache.Set(FormatParseMethodKey, formatParseMethod);

            if (parseNumberMethod is not null)
                _ = cache.Set(ParseNumberMethodKey, parseNumberMethod);

            if (formatParseExactMethod is not null)
                _ = cache.Set(FormatParseExactMethodKey, formatParseExactMethod);
        }
    }

    public MethodInfo? GetDefaultParseMethod(CsvColumn column)
        => cache.Get<MethodInfo>(DefautlParseMethodKey);

    public MethodInfo? GetFormatParseMethod(CsvColumn column)
        => cache.Get<MethodInfo>(FormatParseMethodKey);

    public MethodInfo? GetFormatParseExactMethod(CsvColumn column)
        => cache.Get<MethodInfo>(DefautlParseMethodKey);

    public MethodInfo? GetParseNumberMethod(CsvColumn column)
        => cache.Get<MethodInfo>(ParseNumberMethodKey);


    private static MethodInfo? GetParseMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
        => column.Type.GetMethod(nameof(IParsable<int>.Parse), bindingFlags, types);

    private static MethodInfo? GetParseExactMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
        => column.Type.GetMethod(nameof(DateTime.ParseExact), bindingFlags, types);
}
