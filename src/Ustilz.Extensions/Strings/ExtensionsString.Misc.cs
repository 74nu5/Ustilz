namespace Ustilz.Extensions.Strings;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

using JetBrains.Annotations;

/// <summary>The extensions string.</summary>
[PublicAPI]
public static partial class ExtensionsString
{
    /// <summary>The format.</summary>
    /// <param name="template">The template.</param>
    /// <param name="data">The data.</param>
    /// <typeparam name="T">Type à formatter.</typeparam>
    /// <returns>The <see cref="string" />.</returns>
    public static string Format<T>(this string template, T data)
        => Regex.Replace(template, @"\@{([\w\d]+)\}", match => GetValue(match, data)).Replace("{{", "{", StringComparison.CurrentCulture)
                .Replace("}}", "}", StringComparison.CurrentCulture);

    /// <summary>Méthode de génération des initiales.</summary>
    /// <param name="nom">The nom.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">startIndex plus length indicates a position not within this instance. -or- startIndex or length is less than zero.</exception>
    /// <exception cref="ArgumentNullException">The property is set to null.</exception>
    public static string? GenerateInitials(this string? nom) => nom?[..1]?.ToUpper(CultureInfo.CurrentCulture);

    /// <summary>Convert hex String to bytes representation.</summary>
    /// <param name="hexString">Hex string to convert into bytes.</param>
    /// <returns>Bytes of hex string.</returns>
    public static byte[] HexToBytes(this string hexString)
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
    public static string Left(this string value, int length)
        => string.IsNullOrEmpty(value)
               ? throw new ArgumentException($@"'{nameof(value)}' ne peut pas être null ou vide", nameof(value))
               : value.Length > length
                   ? value[..length]
                   : value;

    /// <summary>Returns characters from right of specified length.</summary>
    /// <param name="value">String value.</param>
    /// <param name="length">Max number of charaters to return.</param>
    /// <returns>Returns string from right.</returns>
    public static string Right(this string value, int length) => string.IsNullOrEmpty(value)
                                                                     ? throw new ArgumentException($@"'{nameof(value)}' ne peut pas être null ou vide", nameof(value))
                                                                     : value.Length > length
                                                                         ? value[^length..]
                                                                         : value;

    /// <summary>Splits the string by pascal case.</summary>
    /// <param name="text">The text.</param>
    /// <returns>Return text split by pascal case.</returns>
    public static string SplitPascalCase(this string text)
        => string.IsNullOrEmpty(text) ? text : Regex.Replace(text, "([A-Z])", " $1", RegexOptions.Compiled).Trim();

    /// <summary>Converts string to enum object.</summary>
    /// <typeparam name="T">Type of enum.</typeparam>
    /// <param name="value">String value to convert.</param>
    /// <returns>Returns enum object.</returns>
    public static T ToEnum<T>(this string value)
        where T : struct => (T)Enum.Parse(typeof(T), value, true);

    /// <summary>The to exception.</summary>
    /// <param name="message">The message.</param>
    /// <typeparam name="T">Type de l'exception.</typeparam>
    [SuppressMessage("ReSharper", "UnthrowableException", Justification = "Nope...")]
    public static void ToException<T>(this string message)
        where T : Exception, new() =>
        throw Activator.CreateInstance(typeof(T), message) as T ?? new Exception(message);

    /// <summary>Méthode d'extension de transformation d'une chaine de caractère en SecureString.</summary>
    /// <param name="str">Chaine de caractère à transformer.</param>
    /// <returns>Retourne un objet SecureString correspondant à la chaine passée en paramètre.</returns>
    public static SecureString ToSecureString(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return new();
        }

        var ss = new SecureString();
        foreach (var @char in str)
        {
            ss.AppendChar(@char);
        }

        return ss;
    }

    /// <summary>Méthode d'extension de transformation d'une chaine de caractère en SecureString. la chaine sécurisée est marquée comme étant en lecture seule.</summary>
    /// <param name="str">Chaine de caractère à transformer.</param>
    /// <returns>Retourne un objet SecureString correspondant à la chaine passée en paramètre.</returns>
    public static SecureString ToSecureStringReadOnly(this string str)
    {
        var ss = ToSecureString(str);
        ss.MakeReadOnly();
        return ss;
    }

    /// <summary>
    ///     A string extension method that removes the diacritics character from the strings.
    /// </summary>
    /// <param name="str">The @this to act on.</param>
    /// <returns>The string without diacritics character.</returns>
    public static string RemoveDiacritics(this string str)
    {
        string normalizedString = str.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (var t in from t in normalizedString let uc = CharUnicodeInfo.GetUnicodeCategory(t) where uc != UnicodeCategory.NonSpacingMark select t)
        {
            sb.Append(t);
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }

    /// <summary>The get value.</summary>
    /// <param name="match">The match.</param>
    /// <param name="data">The data.</param>
    /// <typeparam name="T">Type à inspecter.</typeparam>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentException">Lève une exception lorsque la propriété et/ou la valeur n'est pas trouvé.</exception>
    private static string GetValue<T>(Match match, T data)
    {
        var paraName = match.Groups[1].Value;
        try
        {
            var proper = typeof(T).GetProperty(paraName);
            return proper?.GetValue(data)?.ToString() ?? string.Empty;
        }
        catch (Exception)
        {
            throw new ArgumentException($"Not find '{paraName}'");
        }
    }
}
