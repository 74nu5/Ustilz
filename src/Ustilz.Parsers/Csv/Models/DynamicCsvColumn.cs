namespace Ustilz.Parsers.Csv.Models;

using System.Text.RegularExpressions;

internal sealed class DynamicCsvColumn(string columnName, Type columnType) : CsvColumn(columnName, columnType)
{
    /// <inheritdoc />
    public override int Index => int.MaxValue;

    /// <summary>
    ///     Obtient une expression régulière permettant d'extraire une ou plusieurs valeurs du titre des colonnes.
    /// </summary>
    public Regex HeaderRegex { get; init; } = new(string.Empty);

    public required CsvColumn InternalCsvColumn { get; init; }

    public Dictionary<string, int> NamesIndexes { get; } = [];
}
