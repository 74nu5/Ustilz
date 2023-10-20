namespace Ustilz.Parsers.Csv.Abstractions;

using System.Globalization;

/// <summary>
///     Attribut permettant de définir une colonne de type number d'un fichier CSV.
/// </summary>
internal interface ICsvColumnNumber
{
    /// <summary>
    ///     Obtient le style de la colonne.
    /// </summary>
    NumberStyles Style { get; }
}
