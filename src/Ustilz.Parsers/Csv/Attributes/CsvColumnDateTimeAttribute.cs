namespace Ustilz.Parsers.Csv.Attributes;

using System.Diagnostics.CodeAnalysis;

using JetBrains.Annotations;
using Ustilz.Parsers.Csv.Abstractions;

/// <summary>
///     Attribut permettant de définir une colonne de type date d'un fichier CSV.
/// </summary>
[PublicAPI]
public sealed class CsvColumnDateTimeAttribute
    : CsvColumnAttribute<DateTime>, ICsvColumnFormatter
{
    /// <summary>
    ///     Attribut permettant de définir une colonne de type date d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    public CsvColumnDateTimeAttribute(string columnName)
        : base(columnName)
    {
    }

    /// <inheritdoc />
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    public string Format { get; set; } = string.Empty;
}
