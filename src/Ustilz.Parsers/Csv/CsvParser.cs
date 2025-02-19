namespace Ustilz.Parsers.Csv;

using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using Ustilz.Parsers.Csv.Abstractions;
using Ustilz.Parsers.Csv.Attributes;
using Ustilz.Parsers.Csv.Enums;
using Ustilz.Parsers.Csv.Models;
using Ustilz.Parsers.Extensions;

/// <summary>
///     Classe abstraite représentant un parser de fichier CSV.
/// </summary>
/// <param name="cache">Le <see cref="IMemoryCache" /> permettant de mettre en cache les méthodes de parsing.</param>
/// <param name="logger">Le <see cref="ILogger{TCategoryName}" /> permettant de logger.</param>
public abstract class CsvParser(IMemoryCache cache, ILogger<CsvParser> logger)
{
    private const char NewLineReplacement = '\u1c70'; // 0x1c70 "ᱰ";
    private const BindingFlags PropertyBindingFlags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;
    private static readonly Type[] DateTimeParseExactTypes = [typeof(string), typeof(string[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime).MakeByRefType()];
    private static readonly Type[] DateOnlyParseExactTypes = [typeof(string), typeof(string[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateOnly).MakeByRefType()];
    private static readonly Type[] ParseCultureTypes = [typeof(string), typeof(IFormatProvider)];
    private static readonly Type[] ParseTypes = [typeof(string)];
    private static readonly Type[] NumberStylesTypes = [typeof(string), typeof(NumberStyles), typeof(IFormatProvider)];
    private static readonly char[] SpecialsChars = ['\r', '"', '\n'];
    private static readonly char[] TrimValues = ['\r', '\n', '\"'];
    private static readonly object?[] DateParseExactParameters = new object?[5];

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

        // Si aucune colonne n'a été trouvée, on lève une exception
        if (columns.Count == 0)
            throw new InvalidDataException("Aucune colonne n'a été trouvée.");

        // Détermine l'encodage à utiliser
        var encoding = this.GetEncodingToUse(filePath, options);

        var byteToSkip = 0;

        // Si le fichier ne contient pas d'en-tête, on vérifie que toutes les colonnes ont un index
        if (!options.HasHeader)
        {
            if (columns.TrueForAll(col => col.Index == -1))
                throw new InvalidDataException("Aucune colonne n'a d'index ou n'a été trouvé.");

            if (columns.Exists(col => col.Index == -1))
                logger.LogWarning("Certaines colonnes n'ont pas d'index ou n'ont pas été trouvé.");
        }
        else
        {
            // Sinon, on traite l'en-tête
            (columns, byteToSkip) = ProcessHeader(filePath, columns, encoding, options);

            if (columns.Count == 0)
                throw new InvalidDataException("Aucune colonne n'a été trouvée.");
        }

        var parsedType = typeof(TTypeToParsed);

        logger.LogDebug("Header traité en {Elapsed}.", watch.Elapsed);
        watch = Stopwatch.StartNew();

        var result = this.ParseLines<TOutput, TTypeToParsed>(filePath, byteToSkip, encoding, options, columns, parsedType, postProcessLine);

        logger.LogDebug("{FileName} : {Count} lignes parsées en {Elapsed}.", Path.GetFileName(filePath), result.Count, watch.Elapsed);
        watch.Stop();

        return result;
    }

    private static Encoding DetectEncoding(string filePath)
    {
        var buffer = new byte[4];

        using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        if (fs.Length < 2)
            return Encoding.ASCII; // Not enough data to determine encoding

        _ = fs.Read(buffer, 0, 4);

        var encodingSpan = new ReadOnlySpan<byte>(buffer, 0, 4);

        // Check for BOMs (Byte Order Mark)
        if (Encoding.UTF8.Preamble.SequenceEqual(encodingSpan[..3])) // UTF-8
            return Encoding.UTF8;

        if (Encoding.UTF32.Preamble.SequenceEqual(encodingSpan[..4])) // UTF-32 LE
            return Encoding.UTF32;

        var utf32Encoding = new UTF32Encoding(true, true);

        if (utf32Encoding.Preamble.SequenceEqual(encodingSpan[..4])) // UTF-32 BE
            return utf32Encoding;

        if (Encoding.BigEndianUnicode.Preamble.SequenceEqual(encodingSpan[..2])) // UTF-16 BE
            return Encoding.BigEndianUnicode;

        if (Encoding.Unicode.Preamble.SequenceEqual(encodingSpan[..2])) // UTF-16 LE
            return Encoding.Unicode;

        // If no BOM is found, we can assume ASCII or UTF-8 without BOM
        // This is a simplistic assumption; in a real scenario, you might need more sophisticated heuristics
        return Encoding.ASCII;
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
        var properties = type.GetProperties(PropertyBindingFlags);

        if (properties.Length == 0)
            return [];

        List<CsvColumn> columnCollection = [];

        foreach (var property in properties)
        {
            if (columnCollection.LastOrDefault() is DynamicCsvColumn)
                throw new InvalidOperationException("La colonne dynamique doit être la dernière colonne du fichier.");

            var csvColumnAttribute = property.GetCustomAttribute<CsvColumnAttribute>(true);

            if (csvColumnAttribute is null)
                continue;

            var dynamicAttr = property.GetCustomAttribute<CsvColumnDynamicAttribute>(true);

            var columnType = csvColumnAttribute.GetType().GetGenericArguments().FirstOrDefault()
                          ?? csvColumnAttribute.GetType().BaseType?.GetGenericArguments().FirstOrDefault()
                          ?? throw new InvalidOperationException($"The type of the column {property.Name} must be defined.");

            if (dynamicAttr is not null)
            {
                columnCollection.Add(GetDynamicCsvColumn(property, dynamicAttr, csvColumnAttribute, columnType));
                continue;
            }

            columnCollection.Add(GetCsvColumn(property, csvColumnAttribute, columnType));
        }

        return columnCollection;
    }

    private static DynamicCsvColumn GetDynamicCsvColumn(PropertyInfo property, CsvColumnDynamicAttribute dynamicAttr, CsvColumnAttribute csvColumnAttribute, Type columnType)
    {
        if (property.PropertyType.GetInterface(nameof(IDictionary)) is null)
            throw new InvalidOperationException($"The type of the column {property.Name} must be a dictionary.");

        return new(property.Name, property.PropertyType, csvColumnAttribute.Nullable)
        {
            HeaderRegex = GetHeaderRegex(dynamicAttr, property), PropertyName = property.Name, InternalCsvColumn = CreateColumn(csvColumnAttribute, property.Name, columnType, property),
        };
    }

    private static CsvColumn GetCsvColumn(PropertyInfo property, CsvColumnAttribute csvColumnAttribute, Type columnType)
    {
        var columnName = GetColumnName(csvColumnAttribute, property.Name);
        return CreateColumn(csvColumnAttribute, columnName, columnType, property);
    }

    private static Regex GetHeaderRegex(CsvColumnDynamicAttribute dynamicAttr, MemberInfo property)
    {
        var headerRegex = new Regex(dynamicAttr.HeaderRegex, RegexOptions.Compiled);

        if (headerRegex.GetGroupNames().Length == 1)
            throw new InvalidOperationException($"The regex of the column {property.Name} must have only one captured group.");

        if (Array.IndexOf(headerRegex.GetGroupNames(), string.Empty) != -1)
            throw new InvalidOperationException($"The regex of the column {property.Name} must have a named captured group.");

        return headerRegex;
    }

    private static CsvColumn CreateColumn(CsvColumnAttribute displayAttr, string columnName, Type columnType, MemberInfo property)
        => displayAttr switch
        {
            ICsvColumnNumber attrNumber => new NumberCsvColumn(columnName, columnType, displayAttr.Nullable)
            {
                PropertyName = property.Name,
                HomonymNumber = displayAttr.HomonymNumber,
                Index = GetColumnIndex(displayAttr),
                Style = attrNumber.Style,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            ICsvColumnFormatter attrFormat => new FormatCsvColumn(columnName, columnType, displayAttr.Nullable)
            {
                PropertyName = property.Name,
                HomonymNumber = displayAttr.HomonymNumber,
                Index = GetColumnIndex(displayAttr),
                Format = attrFormat.Format,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            ICsvColumnPercentage attrPercentage => new PercentageCsvColumn(columnName, columnType, displayAttr.Nullable)
            {
                PropertyName = property.Name,
                HomonymNumber = displayAttr.HomonymNumber,
                Index = GetColumnIndex(displayAttr),
                Base = attrPercentage.Base,
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
            _ => new(columnName, columnType, displayAttr.Nullable)
            {
                PropertyName = property.Name,
                HomonymNumber = displayAttr.HomonymNumber,
                Index = GetColumnIndex(displayAttr),
                Culture = new(displayAttr.Culture),
                CharReplaceByDefaultValue = displayAttr.CharReplaceByDefaultValue,
                IgnoreValue = displayAttr.IgnoreValue,
            },
        };

    private static (List<CsvColumn> Columns, int ByteToSkip) ProcessHeader(string filePath, List<CsvColumn> columns, Encoding encoding, CsvParsingOptions options)
    {
        // Récupère les colonnes de l'en-tête
        var (headers, byteToSkip) = ParseCsvHeader(filePath, encoding, options);

        // Affecte les index aux colonnes
        SetIndexesToColumns(columns, headers);

        // Retourne les colonnes avec les index triées par index et le nombre de bytes à sauter
        return ([.. columns.OrderBy(column => column.Index)], byteToSkip);
    }

    private static void SetIndexesToColumns(List<CsvColumn> columns, string[] headers)
    {
        var notDynamicColumns = columns.Where(c => c is not DynamicCsvColumn).ToArray();

        // Affecte les index aux colonnes non dynamiques
        foreach (var column in notDynamicColumns)
        {
            var indexOfProperty = Array.IndexOf(headers, column.Name);

            if (indexOfProperty < 0)
                continue;

            column.Index = indexOfProperty;
        }

        // Si la dernière colonne est dynamique, on affecte les index des colonnes dynamiques
        if (columns[^1] is not DynamicCsvColumn dynamicColumn)
            return;

        var maxIndex = notDynamicColumns.Max(column => column.Index);

        for (var i = maxIndex + 1; i < headers.Length; i++)
        {
            var match = dynamicColumn.HeaderRegex.Match(headers[i]).Value;
            dynamicColumn.NamesIndexes.Add(match, i);
        }
    }

    /// <summary>
    ///     Méthode permettant de parser l'en-tête du fichier CSV.
    /// </summary>
    /// <param name="filePath">Le chemin du fichier à parser.</param>
    /// <param name="encoding">L'encodage à utiliser pour lire le fichier.</param>
    /// <param name="options">Les options de parsing à utiliser.</param>
    /// <returns>Un tuple contenant les colonnes de l'en-tête et le nombre de bytes à sauter pour lire les lignes.</returns>
    private static (string[] Headers, int BytesToSkip) ParseCsvHeader(string filePath, Encoding encoding, CsvParsingOptions options)
    {
        List<string> headers = []; // Stocke les colonnes de l'en-tête
        var currentCharIndex = 0; // Indique le caractère courant
        var startColumnIndex = 0; // Indique le début de la colonne
        var inQuotes = false; // Indique si nous sommes entre guillemets
        var byteToSkip = 0; // Indique le nombre de bytes à sauter pour lire les lignes du fichier.

        var buffer = new char[options.MaxLineLength];
        using var reader = new StreamReader(filePath, encoding, true, buffer.Length);

        // Lit le fichier et stocke les données dans le buffer (4096 caractères maximum)
        var preambleLength = encoding.GetPreamble().Length;

        var bytesRead = reader.ReadBlock(buffer, preambleLength, options.MaxLineLength - preambleLength);

        // Si le fichier est vide, on retourne une liste vide
        if (bytesRead <= 0)
            return (headers.ToArray(), 0);

        var headerSpan = new Span<char>(buffer, 0, bytesRead);

        // Si des lignes doivent être sautées
        if (options.LinesSkipped > 0)
        {
            var numberOfNewLine = headerSpan.Count('\n');
            if (numberOfNewLine < options.LinesSkipped)
                throw new InvalidDataException("Le nombre de lignes à sauter est supérieur au nombre de lignes lu par le buffer de la première ligne. Veuillez augmenter la taille buffer (MaxLineLength).");

            var nthIndexOf = headerSpan.NthIndexOf('\n', options.LinesSkipped) + encoding.GetByteCount(['\n']);

            buffer = new char[options.MaxLineLength];

            // Si le stream peut être positionné, on se positionne après les lignes à sauter.
            if (reader.BaseStream.CanSeek)
                _ = reader.BaseStream.Seek(nthIndexOf, SeekOrigin.Begin);

            bytesRead = reader.ReadBlock(buffer, 0, options.MaxLineLength);

            // Si le fichier est vide, on retourne une liste vide
            if (bytesRead <= 0)
                return (headers.ToArray(), 0);

            headerSpan = new(buffer, 0, bytesRead);
            byteToSkip += encoding.GetByteCount(headerSpan[..nthIndexOf]);
        }

        var trimmedSpan = headerSpan.TrimStart('\0');
        byteToSkip += headerSpan.Length - trimmedSpan.Length;

        // Parcours le buffer pour trouver les colonnes
        while (currentCharIndex < trimmedSpan.Length)
        {
            // Récupère le caractère courant
            var currentChar = trimmedSpan[currentCharIndex];

            // Vérifie si nous sommes entre guillemets
            if (currentChar == '"')
                inQuotes = !inQuotes;

            // Vérifie si nous avons trouvé une virgule en dehors des guillemets
            if (currentChar == options.Separator && !inQuotes)
            {
                // Ajoute la colonne entre startIndex et currentIndex
                headers.Add(trimmedSpan[startColumnIndex..currentCharIndex].Trim().Trim('"').ToString());
                startColumnIndex = currentCharIndex + 1; // Déplace le début de la prochaine colonne
            }

            // Si nous trouvons un retour à la ligne
            if (currentChar == '\n' && !inQuotes)
            {
                // Ajoute la colonne entre startIndex et currentIndex
                headers.Add(trimmedSpan[startColumnIndex..currentCharIndex].Trim().Trim('"').ToString());

                break; // Arrête le parsing car l'en-tête est terminée
            }

            currentCharIndex++;
        }

        // On retourne les colonnes trouvées et le nombre de bytes à sauter pour lire les lignes
        var readOnlySpan = trimmedSpan[..(currentCharIndex + 1)];
        if (trimmedSpan[currentCharIndex] != '\n')
            throw new InvalidDataException("Le caractère précédent les lignes à parser doit être un retour à la ligne");

        byteToSkip += encoding.GetByteCount(readOnlySpan);
        return (headers.ToArray(), byteToSkip);
    }

    private static string GetParsedStringValue(ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        if (columnValue.IsEmpty)
            return string.Empty;

        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, NewLineReplacement, '\n');
        sanitizeValue.Replace(charReplaceByDefaultValue, '\0');
        return sanitizeValue.ToString();
    }

    private static string GetColumnName(CsvColumnAttribute? displayAttribute, string defaultValue)
        => displayAttribute?.Name ?? defaultValue;

    private static int GetColumnIndex(CsvColumnAttribute? displayAttribute)
        => displayAttribute?.Index ?? -1;

    private static object? GetColumnDefaultValue(Type columnType)
        => typeof(Nullable<>).MakeGenericType(columnType).GetConstructor([columnType])?.Invoke([default!]);

    private static object InvokeParse(MethodBase? parseMethod, ReadOnlySpan<char> sanitizeValue, params object?[] parameters)
        => parseMethod?.Invoke(null, parameters) ?? sanitizeValue.ToString();

    private Encoding GetEncodingToUse(string filePath, CsvParsingOptions options)
    {
        var encoding = DetectEncoding(filePath);
        logger.LogDebug("Encodage détecté : {Encoding}.", encoding.EncodingName);

        if (options.Encoding is not null)
            encoding = options.Encoding;

        logger.LogDebug("Encodage utilisé : {Encoding}.", encoding.EncodingName);
        return encoding;
    }

    /// <summary>
    ///     Méthode permettant de parser les lignes du fichier CSV.
    /// </summary>
    /// <typeparam name="TOutput">Le type de sortie.</typeparam>
    /// <typeparam name="TTypeToParsed">e type de l'objet à parser.</typeparam>
    /// <param name="filePath">Le chemin du fichier à parser.</param>
    /// <param name="byteToSkip">Le nombre de bytes à sauter pour lire les lignes.</param>
    /// <param name="encoding">L'encodage à utiliser pour lire le fichier.</param>
    /// <param name="options">Les options de parsing à utiliser.</param>
    /// <param name="columns">Les colonnes à parser.</param>
    /// <param name="columnType">Le type de l'objet à parser.</param>
    /// <param name="postProcessLine">L'action à effectuer après le parsing de la ligne. Cela permet de faire des traitements supplémentaires sur la ligne.</param>
    /// <returns>Une liste d'objets parsés.</returns>
    private List<TOutput> ParseLines<TOutput, TTypeToParsed>(string filePath,
                                                             int byteToSkip,
                                                             Encoding encoding,
                                                             CsvParsingOptions options,
                                                             List<CsvColumn> columns,
                                                             Type columnType,
                                                             Action<string, TTypeToParsed>? postProcessLine)
            where TTypeToParsed : TOutput, new()
    {
        var fileName = Path.GetFileName(filePath);
        var result = new List<TOutput>();

        using var reader = new StreamReader(filePath, encoding, true, options.MaxLineLength);
        var endLineByteToSkip = byteToSkip;
        char[] excludedChars = [options.Separator, .. SpecialsChars];

        var buffer = new char[options.MaxLineLength];

        var fields = new List<Range>(columns.Count + 1); // Stocke les plages des champs

        // Parcours le fichier pour parser les lignes
        while (endLineByteToSkip < reader.BaseStream.Length - 1)
        {
            // Efface le buffer
            reader.DiscardBufferedData();

            // Si le stream peut être positionné, on se positionne à la ligne suivante
            if (reader.BaseStream.CanSeek)
                _ = reader.BaseStream.Seek(endLineByteToSkip, SeekOrigin.Begin);

            // Lit le fichier et stocke les données dans le buffer (4096 caractères maximum)
            var bytesRead = reader.ReadBlock(buffer, 0, options.MaxLineLength);

            var spanBuffer = new Span<char>(buffer, 0, bytesRead).TrimStart();
            var startColumnIndex = 0; // Indique le début de la colonne
            var currentCharIndex = startColumnIndex; // Indique le caractère courant
            var inQuotes = false; // Indique si nous sommes entre guillemets

            while (currentCharIndex < spanBuffer.Length)
            {
                var currentChar = spanBuffer[currentCharIndex];

                // Incrémente le nombre de bytes à sauter
                endLineByteToSkip += encoding.GetByteCount([currentChar]);

                if (currentChar == '\r')
                {
                    currentCharIndex++;
                    continue;
                }

                var currentCharIsQuote = currentChar == '"';

                // Verifie si nous sommes dans le cas ou nous avons un guillemet au milieu d'un valeur.
                if (currentCharIsQuote && currentCharIndex > 0 && currentCharIndex < options.MaxLineLength)
                {
                    var previousChar = spanBuffer[currentCharIndex - 1];
                    var nextChar = spanBuffer[currentCharIndex + 1];

                    if (previousChar != options.Separator && nextChar != options.Separator && !excludedChars.Contains(nextChar))
                    {
                        currentCharIndex++;
                        continue;
                    }
                }

                // Vérifie si nous sommes entre guillemets
                if (currentCharIsQuote)
                    inQuotes = !inQuotes;

                // Vérifie si nous avons trouvé un séparateur en dehors des guillemets
                if (currentChar == options.Separator && !inQuotes)
                {
                    var range = new Range(startColumnIndex, currentCharIndex);
                    var value = spanBuffer[range];

                    if (value.StartsWith("\"") && value.EndsWith("\""))
                        fields.Add(new(startColumnIndex + 1, currentCharIndex - 1));
                    else
                        fields.Add(range); // Ajoute la plage du champ entre startIndex et currentIndex

                    startColumnIndex = currentCharIndex + 1; // Déplace le début du prochain champ
                }

                // Si nous trouvons un retour à la ligne et ne sommes pas entre guillemets
                if (currentChar == '\n' && !inQuotes)
                {
                    // Ajoute la plage du champ entre startIndex et currentIndex
                    fields.Add(new(startColumnIndex, currentCharIndex - 1));
                    break; // Arrête le parsing de la ligne
                }

                currentCharIndex++;
            }

            if (fields.Count <= 0)
                continue;

            // Crée un span de la ligne
            var lineSpan = spanBuffer[..currentCharIndex];
            var typeToParsed = new TTypeToParsed();

            foreach (var column in columns)
            {
                if (column.Index is -1 or int.MaxValue)
                    continue;

                if (column.Index < 0)
                    continue;

                var columnValue = fields[column.Index];

                var spanValue = lineSpan[columnValue];

                if (options.TrimValues)
                    spanValue = spanValue.Trim();

                var parsed = this.GetParsedValue(column, spanValue.Trim(TrimValues));

                var propertyInfo = columnType.GetProperty(column.PropertyName, PropertyBindingFlags);

                if (parsed is null)
                    continue;

                // Vérifie si le type de la valeur parsée correspond au type de la propriété
                if (propertyInfo is not null && parsed.GetType() != propertyInfo.PropertyType && propertyInfo.PropertyType.IsGenericType && parsed.GetType() != propertyInfo.PropertyType.GetGenericArguments()[0])
                    throw new InvalidDataException($"L{result.Count} : The type {parsed.GetType()} of the value {parsed} does not correspond to the type {propertyInfo.PropertyType} of the expected property {propertyInfo.Name} of type {typeof(TTypeToParsed)}.");

                // Vérifie si la colonne est nullable
                if (column.IsNullableColumn)
                {
                    var parsedNullable = typeof(Nullable<>).MakeGenericType(column.Type).GetConstructor([column.Type])?.Invoke([parsed]);
                    propertyInfo?.SetValue(typeToParsed, parsedNullable);
                }
                else
                {
                    propertyInfo?.SetValue(typeToParsed, parsed);
                }
            }

            if (columns[^1] is DynamicCsvColumn dynamicColumn)
            {
                foreach (var (name, index) in dynamicColumn.NamesIndexes)
                {
                    var columnValue = fields[index];

                    var spanValue = lineSpan[columnValue];

                    if (options.TrimValues)
                        spanValue = spanValue.Trim();

                    var parsed = this.GetParsedValue(dynamicColumn, spanValue.Trim('\"'));

                    if (columnType.GetProperty(dynamicColumn.PropertyName, PropertyBindingFlags)?.GetValue(typeToParsed) is IDictionary dictionary && parsed is not null)
                        dictionary.Add(name, parsed);
                }
            }

            postProcessLine?.Invoke(fileName, typeToParsed);

            result.Add(typeToParsed);
            fields.Clear();
        }

        return result;
    }

    private object? GetParsedValue(CsvColumn column, ReadOnlySpan<char> columnValue)
    {
        try
        {
            if (columnValue.IsEmpty || (column.IsNullableColumn && columnValue.Contains("null", StringComparison.InvariantCultureIgnoreCase)))
                return null;

            return column switch
            {
                _ when column.Type == typeof(string) => GetParsedStringValue(columnValue, column.CharReplaceByDefaultValue),
                PercentageCsvColumn percentageColumn => this.GetParsedPercentageValue(percentageColumn, columnValue, column.CharReplaceByDefaultValue),
                NumberCsvColumn numberColumn => this.GetParsedNumberValue(numberColumn, columnValue, column.CharReplaceByDefaultValue),
                FormatCsvColumn formatColumn => this.GetParsedFormatValue(formatColumn, columnValue, column.CharReplaceByDefaultValue),
                DynamicCsvColumn dynamicColumn => this.GetParsedValue(dynamicColumn.InternalCsvColumn, columnValue),
                _ => this.GetDefaultParsedValue(column, columnValue, column.CharReplaceByDefaultValue),
            };
        }
        catch (Exception e)
        {
            logger.LogError(e, "Une erreur est survenue lors du parsing de la colonne {ColumnName}.", column.Name);
            throw;
        }
    }

    private object? GetParsedPercentageValue(PercentageCsvColumn percentageColumn, ReadOnlySpan<char> columnValue, char columnCharReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];

        if (percentageColumn.Base is not null)
            columnValue.Replace(sanitizeValue, '%', '\0');

        var parsedPercentageValue = this.GetParsedNumberValue(percentageColumn, sanitizeValue, columnCharReplaceByDefaultValue);

        if (percentageColumn.Type.IsAssignableTo(typeof(INumber<>).MakeGenericType(percentageColumn.Type)) && percentageColumn.Base == BasePercentage.Base100)
        {
            var number = Convert.ChangeType(parsedPercentageValue, percentageColumn.Type, CultureInfo.InvariantCulture);
            return (decimal?)number / 100;
        }

        return parsedPercentageValue;
    }

    private object? GetParsedNumberValue(NumberCsvColumn numberColumn, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, '0');

        if (sanitizeValue.ContainsAny(numberColumn.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(numberColumn.Type);

        var parseNumberStyleMethod = this.GetParseMethod(numberColumn, BindingFlags.Public | BindingFlags.Static, NumberStylesTypes);
        return InvokeParse(parseNumberStyleMethod, sanitizeValue, sanitizeValue.ToString(), numberColumn.Style ?? NumberStyles.Any, numberColumn.Culture);
    }

    private object? GetParsedFormatValue(FormatCsvColumn formatColumn, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, '\0');

        if (sanitizeValue.ContainsAny(formatColumn.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(formatColumn.Type);

        var parseExactWithFormatMethod = this.GetParseExactWithFormatMethod(formatColumn);

        if (parseExactWithFormatMethod != null)
        {
            DateParseExactParameters[0] = sanitizeValue.ToString();
            DateParseExactParameters[1] = formatColumn.Format;
            DateParseExactParameters[2] = formatColumn.Culture;
            DateParseExactParameters[3] = DateTimeStyles.None;
            DateParseExactParameters[4] = null;

            var parseResult = (bool?)parseExactWithFormatMethod.Invoke(null, DateParseExactParameters);

            if (parseResult ?? false)
                return DateParseExactParameters[4];
        }

        var parseWithFormatMethod = this.GetParseMethod(formatColumn, BindingFlags.Public | BindingFlags.Static, ParseCultureTypes);
        return InvokeParse(parseWithFormatMethod, sanitizeValue, sanitizeValue.ToString(), formatColumn.Culture);
    }

    private MethodInfo? GetParseExactWithFormatMethod(FormatCsvColumn formatColumn)
    {
        if (formatColumn.Type == typeof(DateTime))
            return this.GetTryParseExactMethod(formatColumn, BindingFlags.Public | BindingFlags.Static, DateTimeParseExactTypes);

        if (formatColumn.Type == typeof(DateOnly))
            return this.GetTryParseExactMethod(formatColumn, BindingFlags.Public | BindingFlags.Static, DateOnlyParseExactTypes);

        return null;
    }

    private object? GetDefaultParsedValue(CsvColumn column, ReadOnlySpan<char> columnValue, char charReplaceByDefaultValue)
    {
        Span<char> sanitizeValue = stackalloc char[columnValue.Length];
        columnValue.Replace(sanitizeValue, charReplaceByDefaultValue, '\0');

        if (sanitizeValue.ContainsAny(column.IgnoreValue.AsSpan()))
            return GetColumnDefaultValue(column.Type);

        var parseMethod = this.GetParseMethod(column, BindingFlags.Public | BindingFlags.Static, ParseTypes);
        return InvokeParse(parseMethod, sanitizeValue, sanitizeValue.ToString());
    }

    private MethodInfo? GetParseMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
    {
        column.ParseMethodInfoKey = !string.IsNullOrEmpty(column.ParseMethodInfoKey)
                                            ? column.ParseMethodInfoKey
                                            : $"{column.Type.Name}_{nameof(IParsable<int>.Parse)}_{string.Join(",", types.Select(type => type.Name))}";

        if (cache.TryGetValue(column.ParseMethodInfoKey, out MethodInfo? parseMethod))
            return parseMethod;

        var methodInfo = column.Type.GetMethod(nameof(IParsable<>.Parse), bindingFlags, types);
        _ = cache.Set(column.ParseMethodInfoKey, methodInfo);
        return methodInfo;
    }

    private MethodInfo? GetTryParseExactMethod(CsvColumn column, BindingFlags bindingFlags, params Type[] types)
    {
        column.ParseMethodInfoKey = !string.IsNullOrEmpty(column.ParseMethodInfoKey)
                                            ? column.ParseMethodInfoKey
                                            : $"{column.Type.Name}_{nameof(DateTime.TryParseExact)}_{string.Join(",", types.Select(type => type.Name))}";

        if (cache.TryGetValue(column.ParseMethodInfoKey, out MethodInfo? parseMethod))
            return parseMethod;

        var methodInfo = column.Type.GetMethod(nameof(DateTime.TryParseExact), bindingFlags, types);

        if (methodInfo is null)
            return null;

        _ = cache.Set(column.ParseMethodInfoKey, methodInfo);
        return methodInfo;
    }
}
