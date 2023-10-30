namespace Ustilz.Parsers.Csv.Models;

using System.Globalization;

/// <summary>
///     Représente une colonne d'un fichier CSV.
/// </summary>
internal class NumberCsvColumn : CsvColumn
{
    /// <summary>
    ///     Représente une colonne d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    /// <param name="columnType">Type de la colonne.</param>
    public NumberCsvColumn(string columnName, Type columnType)
        : base(columnName, columnType)
    {
    }

    /// <summary>
    ///     Obtient le style de la colonne.
    /// </summary>
    public NumberStyles? Style { get; internal init; }
}
