namespace Ustilz.Parsers.Csv.Models;

using JetBrains.Annotations;
using Ustilz.Parsers.Csv.Enums;

/// <summary>
///     Représente une colonne d'un fichier CSV.
/// </summary>
[PublicAPI]
internal sealed class PercentageCsvColumn : NumberCsvColumn
{
    /// <summary>
    ///     Représente une colonne d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    /// <param name="columnType">Type de la colonne.</param>
    public PercentageCsvColumn(string columnName, Type columnType)
        : base(columnName, columnType)
    {
    }

    /// <summary>
    ///     Obtient la base de la colonne.
    /// </summary>
    public BasePercentage? Base { get; internal set; }
}
