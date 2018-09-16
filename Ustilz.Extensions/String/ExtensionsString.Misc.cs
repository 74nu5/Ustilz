namespace Ustilz.Extensions.String
{
    #region Usings

    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions string.</summary>
    [PublicAPI]
    public static partial class ExtensionsString
    {
        #region Méthodes publiques

        /// <summary>The to string format.</summary>
        /// <param name="stringFormat">The string format.</param>
        /// <param name="stringParams">The string params.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string F(this string stringFormat, params object[] stringParams)
            => string.Format(stringFormat, stringParams);

        /// <summary>The format.</summary>
        /// <param name="template">The template.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T">Type à formatter.</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        public static string Fs<T>(this string template, T data)
            => Regex.Replace(template, @"\@{([\w\d]+)\}", match => GetValue(match, data)).Replace("{{", "{").Replace("}}", "}");

        /// <summary>Convert hex String to bytes representation.</summary>
        /// <param name="hexString">Hex string to convert into bytes.</param>
        /// <returns>Bytes of hex string.</returns>
        [NotNull]
        public static byte[] HexToBytes([NotNull] this string hexString)
        {
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
        public static bool IsNullOrEmpty(this string str)
            => string.IsNullOrEmpty(str);

        /// <summary>The join.</summary>
        /// <param name="strs">The strs.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string Join(this string[] strs, string separator)
            => string.Join(separator, strs);

        /// <summary>Returns characters from left of specified length.</summary>
        /// <param name="value">String value.</param>
        /// <param name="length">Max number of charaters to return.</param>
        /// <returns>Returns string from left.</returns>
        [CanBeNull]
        public static string Left([CanBeNull] this string value, int length)
            => value != null && value.Length > length ? value.Substring(0, length) : value;

        /// <summary>Returns characters from right of specified length.</summary>
        /// <param name="value">String value.</param>
        /// <param name="length">Max number of charaters to return.</param>
        /// <returns>Returns string from right.</returns>
        [CanBeNull]
        public static string Right([CanBeNull] this string value, int length)
            => value != null && value.Length > length ? value.Substring(value.Length - length) : value;

        /// <summary>Converts string to enum object.</summary>
        /// <typeparam name="T">Type of enum.</typeparam>
        /// <param name="value">String value to convert.</param>
        /// <returns>Returns enum object.</returns>
        [System.Diagnostics.Contracts.Pure]
        public static T ToEnum<T>(this string value)
            where T : struct
            => (T)Enum.Parse(typeof(T), value, true);

        /// <summary>The to exception.</summary>
        /// <param name="message">The message.</param>
        /// <typeparam name="T">Type de l'exception.</typeparam>
        public static void ToException<T>(this string message)
            where T : Exception, new()
            => throw (T)Activator.CreateInstance(typeof(T), message);

        #endregion

        #region Méthodes privées

        /// <summary>The get value.</summary>
        /// <param name="match">The match.</param>
        /// <param name="data">The data.</param>
        /// <typeparam name="T">Type à inspecter.</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentException">Lève une exception lorsque la propriété et/ou la valeur n'est pas trouvé.</exception>
        private static string GetValue<T>([NotNull] Match match, T data)
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

        #endregion
    }
}
