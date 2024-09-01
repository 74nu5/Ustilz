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
    ///     Initializes a new instance of the <see cref="CsvParsingOptions" /> class.
    /// </summary>
    public CsvParsingOptions()
    {
    }

    /// <summary>
    ///     Indicates whether the CSV file has a header.
    /// </summary>
    /// <remarks>This parameter is required.</remarks>
    public required bool HasHeader { get; init; } = false;

    /// <summary>
    ///     The separator used in the CSV file. By default, it is a comma.
    /// </summary>
    public char Separator { get; init; } = ',';

    /// <summary>
    ///     The encoding to use for reading the file. By default, it is UTF-8.
    /// </summary>
    public Encoding? Encoding { get; init; }

    /// <summary>
    ///     Indicates whether the parser should handle new lines. By default, no.
    /// </summary>
    /// <remarks>Attention, CSV files generated from Excel may contain fields with line breaks.</remarks>
    public bool EnableNewLineHandling { get; init; } = false;

    /// <summary>
    ///     Indicates whether the parser should handle double quotes. By default, no.
    /// </summary>
    /// <remarks>Attention, CSV files generated from Excel may contain fields with double quotes.</remarks>
    public bool EnableDoubleQuotesHandling { get; init; } = false;

    /// <summary>
    ///     Gets or sets the maximum length of a line. By default, 4096.
    /// </summary>
    public int MaxLineLength { get; init; } = 4096;

    /// <summary>
    ///     Gets or sets a value indicating whether values should be trimmed.
    /// </summary>
    public bool TrimValues { get; init; } = false;
}
