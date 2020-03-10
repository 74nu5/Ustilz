namespace Ustilz.Extensions.Enumerables
{
    #region Usings

    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using Ustilz.Extensions.String;

    #endregion

    /// <summary>The extensions i enumerable.</summary>
    public static partial class ExtensionsIEnumerable
    {
        #region Méthodes publiques

        /// <summary>Converts bytes collection to hexadecimal representation.</summary>
        /// <param name="bytes">Bytes to convert.</param>
        /// <returns>Hexadecimal representation string.</returns>
        public static string ToHexString([NotNull] this IEnumerable<byte> bytes)
        {
            if (bytes is null)
            {
                throw new System.ArgumentNullException(nameof(bytes));
            }

            return string.Join(string.Empty, bytes.Select(b => $"0{b:X}".Right(2)));
        }

        #endregion
    }
}
