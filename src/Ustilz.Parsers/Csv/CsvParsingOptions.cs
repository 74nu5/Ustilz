namespace Ustilz.Parsers.Csv;

using System.Text;

using JetBrains.Annotations;

/// <summary>
///     An object representing parsing options.
/// </summary>
[PublicAPI]
public readonly struct CsvParsingOptions
{
    /// <summary>
    ///     Initialise une nouvelle instance de la structure <see cref="CsvParsingOptions" />.
    /// </summary>
    public CsvParsingOptions()
    {
    }

    /// <summary>
    ///     Obtient une valeur indiquant si indique si le fichier CSV contient un header.
    /// </summary>
    /// <remarks>Ce paramètre est obligatoire.</remarks>
    public required bool HasHeader { get; init; } = false;

    /// <summary>
    ///     Obtient le séparateur utilisé dans le fichier CSV. Par défaut, c'est la virgule.
    /// </summary>
    public char Separator { get; init; } = ',';

    /// <summary>
    ///     Obtient l'encodage à utiliser pour la lecture du fichier. Par défaut, c'est l'UTF-8.
    /// </summary>
    public Encoding? Encoding { get; init; }

    /// <summary>
    ///     Obtient une valeur indiquant si indique si le parseur devrait gérer les sauts de ligne. Par défaut, non.
    /// </summary>
    /// <remarks>Attention, les fichiers CSV générés à partir d'Excel peuvent contenir des champs avec des retours à la ligne.</remarks>
    public bool EnableNewLineHandling { get; init; } = false;

    /// <summary>
    ///     Obtient une valeur indiquant si indique si le parseur devrait gérer les guillemets. Par défaut, non.
    /// </summary>
    /// <remarks>Attention, les fichiers CSV générés à partir d'Excel peuvent contenir des champs avec des doubles guillemets.</remarks>
    public bool EnableDoubleQuotesHandling { get; init; } = false;

    /// <summary>
    ///     Obtient la longueur maximale d'une ligne. Par défaut, 4096.
    /// </summary>
    public int MaxLineLength { get; init; } = 4096;

    /// <summary>
    ///     Obtient une valeur indiquant si les valeurs doivent être tronquées.
    /// </summary>
    public bool TrimValues { get; init; } = false;

    /// <summary>
    ///     Obtient le nombre de lignes à sauter.
    /// </summary>
    public int LinesSkipped { get; init; }
}
