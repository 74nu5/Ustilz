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
    /// <param name="nullable">Indique si la colonne est nullable.</param>
    public FormatCsvColumn(string columnName, Type columnType, bool nullable)
        : base(columnName, columnType, nullable)
    {
    }

    /// <summary>
    ///     Obtient le format de la colonne.
    /// </summary>
    public string Format { get; init; } = string.Empty;
}
