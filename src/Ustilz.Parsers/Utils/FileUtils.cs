namespace Ustilz.Parsers.Utils;

using System.Text;

using JetBrains.Annotations;

/// <summary>
///     Utility class for file management.
/// </summary>
[PublicAPI]
public static class FileUtils
{
    /// <summary>
    ///     Determines the encoding of a file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The encoding of the file.</returns>
    public static Encoding DetectEncoding(Uri filePath)
        => DetectEncoding(filePath.AbsolutePath);

    /// <summary>
    ///     Determines the encoding of a file.
    /// </summary>
    /// <param name="fileInfo">The file path.</param>
    /// <returns>The encoding of the file.</returns>
    public static Encoding DetectEncoding(FileInfo fileInfo)
        => DetectEncoding(fileInfo.FullName);

    /// <summary>
    ///     Determines the encoding of a file.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The encoding of the file.</returns>
    public static Encoding DetectEncoding(string filePath)
    {
        var buffer = new byte[4];

        using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        if (fs.Length < 2)
            return Encoding.ASCII; // Not enough data to determine encoding

        _ = fs.Read(buffer, 0, 4);

        var encodingSpan = new ReadOnlySpan<byte>(buffer, 0, 4);

        // Check for BOMs (Byte Order Mark)
        if (Encoding.UTF8.Preamble.SequenceEqual(encodingSpan[..3])) // UTF-8
            return Encoding.UTF8;

        if (Encoding.UTF32.Preamble.SequenceEqual(encodingSpan[..4])) // UTF-32 LE
            return Encoding.UTF32;

        var utf32Encoding = new UTF32Encoding(true, true);

        if (utf32Encoding.Preamble.SequenceEqual(encodingSpan[..4])) // UTF-32 BE
            return utf32Encoding;

        if (Encoding.BigEndianUnicode.Preamble.SequenceEqual(encodingSpan[..2])) // UTF-16 BE
            return Encoding.BigEndianUnicode;

        if (Encoding.Unicode.Preamble.SequenceEqual(encodingSpan[..2])) // UTF-16 LE
            return Encoding.Unicode;

        // If no BOM is found, we can assume ASCII or UTF-8 without BOM
        // This is a simplistic assumption; in a real scenario, you might need more sophisticated heuristics
        return Encoding.ASCII;
    }
}
