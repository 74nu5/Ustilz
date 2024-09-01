namespace Ustilz.Parsers.Csv.Abstractions;

using System.Reflection;

using Ustilz.Parsers.Csv.Models;

internal interface IMethodsParseProvider
{
    void AddParseMethodsToCache(IEnumerable<CsvColumn> columns);

    MethodInfo? GetDefaultParseMethod(CsvColumn column);

    MethodInfo? GetFormatParseMethod(CsvColumn column);

    MethodInfo? GetFormatParseExactMethod(CsvColumn column);

    MethodInfo? GetParseNumberMethod(CsvColumn column);
}
