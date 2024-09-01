namespace Ustilz.Parsers.Csv.Abstractions;

using Ustilz.Parsers.Csv.Enums;

/// <summary>
///     Attribut permettant de définir une colonne de type pourcentage d'un fichier CSV.
/// </summary>
internal interface ICsvColumnPercentage
{
    /// <summary>
    ///     Obtient la base de la colonne.
    /// </summary>
    BasePercentage Base { get; }
}
