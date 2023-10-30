namespace Ustilz.Parsers.Csv.Models;

/// <summary>
///     Représente une colonne d'un fichier CSV.
/// </summary>
internal sealed class FormatCsvColumn
    : CsvColumn
{
    /// <summary>
    ///     Représente une colonne d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    /// <param name="columnType">Type de la colonne.</param>
    public FormatCsvColumn(string columnName, Type columnType)
        : base(columnName, columnType)
    {
    }

    /// <summary>
    ///     Obtient le format de la colonne.
    /// </summary>
    public string Format { get; init; } = string.Empty;
}
