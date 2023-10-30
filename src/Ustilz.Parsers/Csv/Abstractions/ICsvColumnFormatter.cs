namespace Ustilz.Parsers.Csv.Abstractions;

/// <summary>
///     Interface permettant de définir une colonne de type format d'un fichier CSV.
/// </summary>
internal interface ICsvColumnFormatter
{
    /// <summary>
    ///     Obtient le format de la colonne.
    /// </summary>
    string Format { get; }
}
