namespace Ustilz.Extensions.Enumerables;

using System;

using Ustilz.Extensions.Strings;

/// <summary>The extensions i enumerable.</summary>
public static partial class EnumerableExtensions
{
    extension(IEnumerable<byte> bytes)
    {
        /// <summary>
        ///     Converts bytes collection to hexadecimal representation.
        /// </summary>
        /// <returns>Hexadecimal representation string.</returns>
        public string ToHexString()
        {
            ArgumentNullException.ThrowIfNull(bytes);

            return string.Join(string.Empty, bytes.Select(b => $"0{b:X}".Right(2)));
        }
    }

    extension(byte[] byteArrayIn)
    {
        /// <summary>
        ///     Converts a byte array to a base64 image.
        /// </summary>
        /// <returns>The base64 image.</returns>
        /// <remarks>
        ///     This method takes a byte array and an image type as input, converts the byte array to a base64 string,
        ///     and then formats it as a data URL with the specified image type.
        /// </remarks>
        public string ByteArrayToBase64Image(string imageType)
            => $"data:image/{imageType};base64,{Convert.ToBase64String(byteArrayIn)}";
    }
}
