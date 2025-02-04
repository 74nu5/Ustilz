namespace Ustilz.Parsers.Csv.Models;

using System.Text.RegularExpressions;

internal sealed class DynamicCsvColumn(string columnName, Type columnType, bool nullable) : CsvColumn(columnName, columnType, nullable)
{
    /// <inheritdoc />
    public override int Index => int.MaxValue;

    /// <summary>
    ///     Obtient une expression régulière permettant d'extraire une ou plusieurs valeurs du titre des colonnes.
    /// </summary>
    public Regex HeaderRegex { get; init; } = new(string.Empty);

    /// <summary>
    ///     Obtient la colonne est une colonne interne.
    /// </summary>
    public required CsvColumn InternalCsvColumn { get; init; }

    /// <summary>
    ///     Obtient les index des colonnes.
    /// </summary>
    public Dictionary<string, int> NamesIndexes { get; } = [];
}
