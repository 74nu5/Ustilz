namespace Ustilz.Parsers.Csv.Attributes;

using System.Globalization;
using System.Numerics;

using JetBrains.Annotations;
using Ustilz.Parsers.Csv.Abstractions;

/// <summary>
///     Attribut permettant de définir une colonne de type nombre d'un fichier CSV.
/// </summary>
/// <typeparam name="TColumnType">Type de la colonne.</typeparam>
[PublicAPI]
public sealed class CsvColumnNumberAttribute<TColumnType>
    : CsvColumnAttribute, ICsvColumnNumber
    where TColumnType : INumberBase<TColumnType>
{
    /// <summary>
    ///     Attribut permettant de définir une colonne de type nombre d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    public CsvColumnNumberAttribute(string columnName)
        : base(columnName)
    {
    }

    /// <inheritdoc />
    public NumberStyles Style { get; set; } = NumberStyles.Any;
}
