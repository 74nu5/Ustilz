namespace Ustilz.Extensions.Strings
{
    #region Usings

    using System;
    using System.Globalization;
    using System.Security;
    using System.Text.RegularExpressions;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions string.</summary>
    [PublicAPI]
    public static partial class ExtensionsString
    {
        /// <summary>The format.</summary>
        /// <param name="template">The template.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T">Type à formatter.</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        public static string Fs<T>(this string template, T data)
            => Regex.Replace(template, @"\@{([\w\d]+)\}", match => GetValue(match, data)).Replace("{{", "{", StringComparison.CurrentCulture)
                    .Replace("}}", "}", StringComparison.CurrentCulture);

        /// <summary>Convert hex String to bytes representation.</summary>
        /// <param name="hexString">Hex string to convert into bytes.</param>
        /// <returns>Bytes of hex string.</returns>
        [NotNull]
        public static byte[] HexToBytes([NotNull] this string hexString)
        {
            if (hexString is null)
            {
                throw new ArgumentNullException(nameof(hexString));
            }

            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException($"HexString cannot be in odd number: {hexString}");
            }

            var retVal = new byte[hexString.Length / 2];
            for (var i = 0; i < hexString.Length; i += 2)
            {
                retVal[i / 2] = byte.Parse(hexString.Substring(i, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return retVal;
        }

        /// <summary>The is null or empty.</summary>
        /// <param name="str">The str.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        /// <summary>The join.</summary>
        /// <param name="strs">The strs.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string Join(this string[] strs, string separator) => string.Join(separator, strs);

        /// <summary>Returns characters from left of specified length.</summary>
        /// <param name="value">String value.</param>
        /// <param name="length">Max number of charaters to return.</param>
        /// <returns>Returns string from left.</returns>
        public static string? Left(this string value, int length) => value != null && value.Length > length ? value.Substring(0, length) : value;

        /// <summary>Returns characters from right of specified length.</summary>
        /// <param name="value">String value.</param>
        /// <param name="length">Max number of charaters to return.</param>
        /// <returns>Returns string from right.</returns>
        public static string? Right(this string value, int length) => value != null && value.Length > length ? value.Substring(value.Length - length) : value;

        /// <summary>Converts string to enum object.</summary>
        /// <typeparam name="T">Type of enum.</typeparam>
        /// <param name="value">String value to convert.</param>
        /// <returns>Returns enum object.</returns>
        [System.Diagnostics.Contracts.Pure]
        public static T ToEnum<T>(this string value)
            where T : struct => (T)Enum.Parse(typeof(T), value, true);

        /// <summary>The to exception.</summary>
        /// <param name="message">The message.</param>
        /// <typeparam name="T">Type de l'exception.</typeparam>
        public static void ToException<T>(this string message)
            where T : Exception, new() =>
            throw (T)Activator.CreateInstance(typeof(T), message);

        /// <summary>Méthode d'extension de transformation d'une chaine de caractère en SecureString.</summary>
        /// <param name="str">Chaine de caractère à transformer.</param>
        /// <param name="markReadOnly">Indique si la chaine sécurisée est marquée comme étant en lecture seule.</param>
        /// <returns>Retourne un objet SecureString correspondant à la chaine passée en paramètre.</returns>
        public static SecureString ToSecureString(this string str, bool markReadOnly = false)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new SecureString();
            }

            var ss = new SecureString();
            foreach (var @char in str)
            {
                ss.AppendChar(@char);
            }

            if (markReadOnly)
            {
                ss.MakeReadOnly();
            }

            return ss;
        }

        /// <summary>The get value.</summary>
        /// <param name="match">The match.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T">Type à inspecter.</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentException">Lève une exception lorsque la propriété et/ou la valeur n'est pas trouvé.</exception>
        private static string? GetValue<T>([NotNull] Match match, T data)
        {
            var paraName = match.Groups[1].Value;
            try
            {
                var proper = typeof(T).GetProperty(paraName);
                return proper?.GetValue(data)?.ToString();
            }
            catch (Exception)
            {
                var errMsg = $"Not find '{paraName}'";
                throw new ArgumentException(errMsg);
            }
        }
    }
}
