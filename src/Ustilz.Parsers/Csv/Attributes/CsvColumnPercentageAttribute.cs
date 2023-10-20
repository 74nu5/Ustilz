namespace Ustilz.Parsers.Csv.Attributes;

using System.Numerics;
using JetBrains.Annotations;
using Ustilz.Parsers.Csv.Abstractions;
using Ustilz.Parsers.Csv.Enums;

/// <summary>
///     Attribut permettant de définir une colonne de type pourcentage d'un fichier CSV.
/// </summary>
/// <typeparam name="TColumnType">Type de la colonne.</typeparam>
[PublicAPI]
public sealed class CsvColumnPercentageAttribute<TColumnType>
    : CsvColumnAttribute<TColumnType>, ICsvColumnPercentage
    where TColumnType : INumberBase<TColumnType>
{
    /// <summary>
    ///     Attribut permettant de définir une colonne de type pourcentage d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    public CsvColumnPercentageAttribute(string columnName)
        : base(columnName)
    {
    }

    /// <inheritdoc />
    public BasePercentage Base { get; set; }
}
