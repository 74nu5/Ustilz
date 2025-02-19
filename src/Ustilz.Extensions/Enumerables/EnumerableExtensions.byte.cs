namespace Ustilz.Extensions.Enumerables;

using Ustilz.Extensions.Strings;

/// <summary>The extensions i enumerable.</summary>
public static partial class EnumerableExtensions
{
    /// <summary>
    ///     Converts bytes collection to hexadecimal representation.
    /// </summary>
    /// <param name="bytes">Bytes to convert.</param>
    /// <returns>Hexadecimal representation string.</returns>
    public static string ToHexString(this IEnumerable<byte> bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);

        return string.Join(string.Empty, bytes.Select(b => $"0{b:X}".Right(2)));
    }

    /// <summary>
    ///     Converts a byte array to a base64 image.
    /// </summary>
    /// <param name="byteArrayIn">Byte array to convert.</param>
    /// <param name="imageType">The image type.</param>
    /// <returns>The base64 image.</returns>
    /// <remarks>
    ///     This method takes a byte array and an image type as input, converts the byte array to a base64 string,
    ///     and then formats it as a data URL with the specified image type.
    /// </remarks>
    public static string ByteArrayToBase64Image(this byte[] byteArrayIn, string imageType)
        => $"data:image/{imageType};base64,{Convert.ToBase64String(byteArrayIn)}";
}
