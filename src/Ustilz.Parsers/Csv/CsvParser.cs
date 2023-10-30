namespace Ustilz.Parsers.Csv;

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using JetBrains.Annotations;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Ustilz.Parsers.Csv.Abstractions;
using Ustilz.Parsers.Csv.Attributes;
using Ustilz.Parsers.Csv.Models;

/// <summary>
///     Classe abstraite représentant un parser de fichier CSV.
/// </summary>
/// <param name="cache">Le <see cref="IMemoryCache" /> permettant de mettre en cache les méthodes de parsing.</param>
/// <param name="logger">Le <see cref="ILogger{TCategoryName}" /> permettant de logger.</param>
[PublicAPI]
public abstract partial class CsvParser(IMemoryCache cache, ILogger<CsvParser> logger)
{
    private const char NewLineReplacementChar = '\u1c70'; // 0x1c70 "ᱰ";

    private const char ZeroChar = '\0';

    private const char NewLineChar = '\n';

    private const int QuoteChar = '\"';

    /// <summary>
    ///     Parse un fichier CSV.
    /// </summary>
    /// <typeparam name="TOutput">Le type de sortie.</typeparam>
    /// <typeparam name="TTypeToParsed">Le type de l'objet à parser.</typeparam>
    /// <param name="filePath">Le chemin du fichier à parser.</param>
    /// <param name="options">Les options de parsing à utiliser.</param>
    /// <param name="postProcessLine">L'action à effectuer après le parsing de la ligne. Cela permet de faire des traitements supplémentaires sur la ligne.</param>
    /// <returns>Une liste de liste d'objets parsés.</returns>
    /// <exception cref="InvalidDataException">Le fichier CSV ne contient aucune ligne.</exception>
    protected IEnumerable<TOutput> Parse<TOutput, TTypeToParsed>(string filePath, CsvParsingOptions options, Action<string, TTypeToParsed>? postProcessLine = null)
        where TTypeToParsed : TOutput, new()
    {
        var watch = Stopwatch.StartNew();

        // Génère les colonnes à partir du type de l'objet à parser.
        var columns = GenerateColumns<TTypeToParsed>();


        if (!options.HasHeader)
        {
            if (columns.All(col => col.Index == -1))
                throw new InvalidDataException("Aucune colonne n'a d'index ou n'a été trouvé.");

            if (columns.Any(col => col.Index == -1))
                logger.LogWarning("Certaines colonnes n'ont pas d'index ou n'ont pas été trouvé.");
        }
        else
        {
            columns = ProcessHeader(filePath, columns, options);
        }

        var commissionType = typeof(TTypeToParsed);


        logger.LogDebug("Header traité en {Elapsed}.", watch.Elapsed);
        watch = Stopwatch.StartNew();

        var result = this.ReadLineAsParallel<TOutput, TTypeToParsed>(filePath, options, columns, commissionType, postProcessLine);

        logger.LogDebug("{FileName} : {Count} lignes parsées en {Elapsed}.", Path.GetFileName(filePath), result.Count, watch.Elapsed);
        watch.Stop();
        return result;
    }

    private static List<CsvColumn> ProcessHeader(string filePath, List<CsvColumn> columns, CsvParsingOptions options)
    {
        var line = GetHeaderLine(filePath, options);
        var columnsArray = line.Split(options.Separator, StringSplitOptions.TrimEntries).ToList();

        foreach (var column in columns)
        {
            var indexOfProperty = columnsArray.IndexOf(column.Name);

            if (indexOfProperty < 0)
                continue;

            column.Index = indexOfProperty;
        }

        return columns.OrderBy(column => column.Index).ToList();
    }

    /// <summary>
    ///     Génère les colonnes à partir du type de l'objet à parser.
    /// </summary>
    /// <typeparam name="TTypeToParse">Le type de l'objet à parser.</typeparam>
    /// <returns>Une liste de <see cref="CsvColumn" />.</returns>
    /// <exception cref="InvalidOperationException">Le type de la colonne {columnName} n'est pas défini.</exception>
    private static List<CsvColumn> GenerateColumns<TTypeToParse>()
    {
        var type = typeof(TTypeToParse);
        var properties = type.GetProperties();

        if (properties.Length == 0)
            return [];

        var columnCollection = new List<CsvColumn>();

        foreach (var property in properties)
        {
            var displayAttr = property.GetCustomAttribute<CsvColumnAttribute>(true);

            if (displayAttr is null)
                continue;

            var columnType = displayAttr.GetType().GetGenericArguments().FirstOrDefault() ?? displayAttr.GetType().BaseType?.GetGenericArguments().FirstOrDefault();


            var columnName = GetColumnName(displayAttr, property.Name);

            if (columnType is null)
                throw new InvalidOperationException($"The type of the column {columnName} is not defined.");

            var column = CreateColumn(displayAttr, columnName, columnType, property);

            columnCollection.Add(column);
        }

        return columnCollection;
    }

    private static CsvColumn CreateColumn(CsvColumnAttribute displayAttr, string columnName, Type columnType, MemberInfo property)
        => displayAttr switch
        {
            ICsvColumnNumber attrNumber => new NumberCsvColumn(columnName, columnType)
            {
                PropertyName = property.Name,
                Index = GetColumnIndex(displayAttr),
                Style = attrNumber.Style,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            ICsvColumnFormatter attrFormat => new FormatCsvColumn(columnName, columnType)
            {
                PropertyName = property.Name,
                Index = GetColumnIndex(displayAttr),
                Format = attrFormat.Format,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            ICsvColumnPercentage attrPercentage => new PercentageCsvColumn(columnName, columnType)
            {
                PropertyName = property.Name,
                Index = GetColumnIndex(displayAttr),
                Base = attrPercentage.Base,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            _ => new(columnName, columnType)
            {
                PropertyName = property.Name,
                Index = GetColumnIndex(displayAttr),
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
        };

    private static string GetColumnName(CsvColumnAttribute? displayAttribute, string defaultValue)
        => displayAttribute?.Name ?? defaultValue;

    private static int GetColumnIndex(CsvColumnAttribute? displayAttribute)
        => displayAttribute?.Index ?? -1;

    private static object? GetColumnDefaultValue(Type columnType)
        => typeof(Nullable<>).MakeGenericType(columnType).GetConstructor(new[] { columnType })?.Invoke(new object[] { default! });

    private static object InvokeParse(MethodBase? parseMethod, ReadOnlySpan<char> sanitizeValue, params object?[] parameters)
        => parseMethod?.Invoke(null, parameters) ?? sanitizeValue.ToString();

    private static string GetHeaderLine(string filePath, CsvParsingOptions options)
    {
        using var reader = new StreamReader(filePath, options.Encoding);
        if (reader.Peek() == -1)
            throw new InvalidDataException("Le fichier CSV ne contient aucune ligne.");

        if (!options.EnableNewLineHandling)
            return reader.ReadLine() ?? string.Empty;

        var sb = new StringBuilder();
        var openQuotes = 0;
        var adjadentQuotes = 0;
        var wasQuote = false;
        int current;
        while ((current = reader.Read()) != -1)
        {
            if (current == NewLineChar && openQuotes == 0)
                break;
            var isQuote = current == QuoteChar;
            if (isQuote)
            {
                openQuotes = (openQuotes + 1) % 2;
                ++adjadentQuotes;
            }
            else if (wasQuote && adjadentQuotes > 0)
            {
                var nbRemoveQuotes = (int)Math.Ceiling(adjadentQuotes / 2f);
                _ = sb.Remove(sb.Length - nbRemoveQuotes, nbRemoveQuotes);
                adjadentQuotes = 0;
            }
            _ = sb.Append((char)current);
            wasQuote = isQuote;
        }
        return sb.ToString();

    }

    private object? GetDefaultParsedValue(CsvColumn column, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, ZeroChar);

        if (sanitizeValue.ContainsAny(column.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(column.Type);

        var parseMethod = this.GetParseMethod(column, BindingFlags.Public | BindingFlags.Static, typeof(string));
        return InvokeParse(parseMethod, sanitizeValue, sanitizeValue.ToString());
    }

    private static object GetParsedStringValue(ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        if (columnValue.IsEmpty)
            return string.Empty;

        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, NewLineReplacementChar, NewLineChar);
        sanitizeValue.Replace(charReplaceByDefaultValue, ZeroChar);
        return sanitizeValue.ToString();
    }

    private object? GetParsedFormatValue(FormatCsvColumn formatColumn, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, ZeroChar);

        if (sanitizeValue.ContainsAny(formatColumn.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(formatColumn.Type);

        var parseExactWithFormatMethod = this.GetParseExactMethod(formatColumn, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(string), typeof(IFormatProvider));

        if (parseExactWithFormatMethod != null)
            return InvokeParse(parseExactWithFormatMethod, sanitizeValue, sanitizeValue.ToString(), formatColumn.Format, formatColumn.Culture);

        var parseWithFormatMethod = this.GetParseMethod(formatColumn, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(IFormatProvider));
        return InvokeParse(parseWithFormatMethod, sanitizeValue, sanitizeValue.ToString(), formatColumn.Format);
    }

    private object? GetParsedPercentageValue(PercentageCsvColumn percentageColumn, ReadOnlySpan<char> columnValue, char columnCharReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];

        if (percentageColumn.Base is not null)
            columnValue.Replace(sanitizeValue, '%', ZeroChar);

        return this.GetParsedNumberValue(percentageColumn, sanitizeValue, columnCharReplaceByDefaultValue);
    }

    private object? GetParsedNumberValue(NumberCsvColumn numberColumn, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, '0');

        if (sanitizeValue.ContainsAny(numberColumn.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(numberColumn.Type);

        if (numberColumn.Style is not null)
        {
            var parseNumberStyleMethod = this.GetParseMethod(numberColumn, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(NumberStyles), typeof(IFormatProvider));
            return InvokeParse(parseNumberStyleMethod, sanitizeValue, sanitizeValue.ToString(), numberColumn.Style, numberColumn.Culture);
        }

        var parseNumberMethod = this.GetParseMethod(numberColumn, BindingFlags.Public | BindingFlags.Static, typeof(string), typeof(NumberStyles), typeof(IFormatProvider));
        return InvokeParse(parseNumberMethod, sanitizeValue, sanitizeValue.ToString(), NumberStyles.Any, numberColumn.Culture);
    }

    private MethodInfo? GetParseMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
    {
        var key = $"{column.Type.Name}_{nameof(IParsable<int>.Parse)}_{string.Join(",", types.Select(type => type.Name))}";

        if (cache.TryGetValue(key, out MethodInfo? parseMethod))
            return parseMethod;

        var methodInfo = column.Type.GetMethod(nameof(IParsable<int>.Parse), bindingFlags, types);
        _ = cache.Set(key, methodInfo);
        return methodInfo;
    }

    private MethodInfo? GetParseExactMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
    {
        var key = $"{column.Type.Name}_{nameof(DateTime.ParseExact)}_{string.Join(",", types.Select(type => type.Name))}";

        if (cache.TryGetValue(key, out MethodInfo? parseMethod))
            return parseMethod;

        var methodInfo = column.Type.GetMethod(nameof(DateTime.ParseExact), bindingFlags, types);
        _ = cache.Set(key, methodInfo);
        return methodInfo;
    }

    private ConcurrentBag<TOutput> ReadLineAsParallel<TOutput, TTypeToParsed>(
        string filePath,
        CsvParsingOptions options,
        List<CsvColumn> columns,
        Type commissionType,
        Action<string, TTypeToParsed>? postProcessLine)
        where TTypeToParsed : TOutput, new()
    {
        var result = new ConcurrentBag<TOutput>();
        var fileName = Path.GetFileName(filePath);
        var lines = this.GetCsvLines(filePath, options);

        lines.Skip(options.HasHeader ? 1 : 0).AsParallel().ForAll(
            line =>
            {
                var lineSpan = line.AsSpan();
                var values = new Span<Range>(new Range[lineSpan.Count(options.Separator) + 1]);
                _ = lineSpan.Split(values, options.Separator, StringSplitOptions.TrimEntries);
                var commission = new TTypeToParsed();

                foreach (var column in columns)
                {
                    if (column.Index == -1)
                        continue;

                    var columnValue = values[column.Index];

                    var parsed = this.GetParsedValue(column, lineSpan[columnValue]);

                    commissionType.GetProperty(column.PropertyName)?.SetValue(commission, parsed);
                }

                postProcessLine?.Invoke(fileName, commission);

                result.Add(commission);
            });

        return result;
    }

    /// <summary>
    ///     Tiré de stackoverflow avec modifications: https://stackoverflow.com/a/18147076
    ///     Exemple sur Regex101.com: https://regex101.com/r/UvBZUT/1
    /// </summary>
    /// <returns></returns>
    [GeneratedRegex("(?:^|;)(?=[^\"]|(\")?)\"((?(1)(?:[^\"]|\"\")*|[^;\"]*))\"(?=;|$)")]
    private partial Regex GetCsvFieldWithNewLineRegex();

    [GeneratedRegex("(\"\")")]
    private partial Regex GetDuoQuotesRegex();

    private object? GetParsedValue(CsvColumn column, ReadOnlySpan<char> columnValue)
    {
        try
        {
            return column switch
            {
                _ when columnValue.IsEmpty => null,
                _ when column.Type == typeof(string) => GetParsedStringValue(columnValue, column.CharReplaceByDefaultValue),
                PercentageCsvColumn percentageColumn => this.GetParsedPercentageValue(percentageColumn, columnValue, column.CharReplaceByDefaultValue),
                NumberCsvColumn numberColumn => this.GetParsedNumberValue(numberColumn, columnValue, column.CharReplaceByDefaultValue),
                FormatCsvColumn formatColumn => this.GetParsedFormatValue(formatColumn, columnValue, column.CharReplaceByDefaultValue),
                _ => this.GetDefaultParsedValue(column, columnValue, column.CharReplaceByDefaultValue),
            };
        }
        catch (Exception e)
        {
            logger.LogError(e, "Une erreur est survenue lors du parsing de la colonne {ColumnName}.", column.Name);
            throw;
        }
    }

    private IEnumerable<string> GetCsvLines(string filePath, CsvParsingOptions options)
    {
        if (options.EnableNewLineHandling)
        {
            var txtSpan = this.GetCsvFieldWithNewLineRegex().Replace(
                File.ReadAllText(filePath, options.Encoding),
                (match) =>
                {
                    var oldValue = match.Groups[0].Value.AsSpan();
                    Span<char> newValue = stackalloc char[oldValue.Length];
                    oldValue.Replace(newValue, NewLineChar, NewLineReplacementChar);
                    var startTrimCount = 1 + (newValue[0] == options.Separator ? 1 : 0);
                    newValue = newValue.Slice(startTrimCount, newValue.Length - (startTrimCount + 1));
                    return (startTrimCount > 1 ? options.Separator : string.Empty) + newValue.ToString();
                }).AsSpan();
            if(options.EnableDoubleQuotesHandling)
            {
                txtSpan = this.GetDuoQuotesRegex().Replace(txtSpan.ToString(), "\"").AsSpan();
            }
            var txtRange = new Span<Range>(new Range[txtSpan.Count(NewLineChar) + 1]);
            _ = txtSpan.Split(txtRange, NewLineChar);

            var list = new List<string>();
            foreach (var range in txtRange)
            {
                if (txtSpan[range].Length > 0)
                    list.Add(txtSpan[range].ToString());
            }
            return list;
        }

        var lines = File.ReadLines(filePath, options.Encoding);
        if (options.EnableDoubleQuotesHandling)
        {
            lines = lines.Select(line => this.GetDuoQuotesRegex().Replace(line, "\""));
        }
        return lines;
    }
}
