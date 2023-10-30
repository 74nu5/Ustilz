namespace Ustilz.Parsers.Csv;

using System.Text;

using JetBrains.Annotations;

/// <summary>
///     Un objet représentant des options de parsing.
/// </summary>
[PublicAPI]
public sealed class CsvParsingOptions
{
    /// <summary>
    ///     Indique si le fichier CSV contient un header.
    /// </summary>
    /// <remarks>Ce paramètre est obligatoire.</remarks>
    public required bool HasHeader { get; set; }

    /// <summary>
    ///     Le séparateur utilisé dans le fichier CSV. Par défaut, c'est la virgule.
    /// </summary>
    public char Separator { get; set; } = ',';

    /// <summary>
    ///     L'encodage à utiliser pour la lecture du fichier. Par défaut, c'est l'UTF-8.
    /// </summary>
    public Encoding Encoding { get; set; } = Encoding.UTF8;

    /// <summary>
    ///     Indique si le parseur devrait gérer les sauts de ligne. Par défaut, non.
    /// </summary>
    /// <remarks>Attention, les fichiers CSV générés à partir d'Excel peuvent contenir des champs avec des retours à la ligne.</remarks>
    public bool EnableNewLineHandling { get; set; }

    /// <summary>
    ///     Indique si le parseur deverait gérer les guillemets. Par défaut, non.
    /// </summary>
    /// <remarks>Attention, les fichiers CSV générés à partir d'Excel peuvent contenir des champs avec des doubles guillements.</remarks>
    public bool EnableDoubleQuotesHandling { get; set; }
}
