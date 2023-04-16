namespace Ustilz.UI;

using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

using JetBrains.Annotations;

/// <summary>The color utils.</summary>
[PublicAPI]
public static class ColorUtils
{
    /// <summary>The random.</summary>
    private static readonly Random Random = new();

    /// <summary>Méthode de génération de couleurs.</summary>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException">maxValue is less than 0.</exception>
    public static string GenerateColor() => $"{Random.Next(0x1000000):X6}";

    /// <summary>The get color from nom.</summary>
    /// <param name="nom">The nom.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="nom" /> is <see langword="null" />.</exception>
    /// <exception cref="FormatException">format includes an unsupported specifier. Supported format specifiers are listed in the Remarks section.</exception>
    /// <exception cref="ArgumentException">
    ///     style is not a <see cref="System.Globalization.NumberStyles"></see> value. -or- style includes the
    ///     <see cref="System.Globalization.NumberStyles.AllowHexSpecifier"></see> or <see cref="System.Globalization.NumberStyles.HexNumber"></see> flag along with another value.
    /// </exception>
    public static string GetColorFromNom(string nom)
    {
        if (nom == null)
            throw new ArgumentNullException(nameof(nom));

        if (nom.Length == 3)
            return $"#{string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X", CultureInfo.CurrentCulture)))}";

        var s = string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X", CultureInfo.CurrentCulture)));
        var bi = BigInteger.Parse(s, NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture);
        var bii = bi % 0xFFFFFF;

        var color = $"#{(long)bii:X6}";
        return color.Length != 7 ? "#000000" : color;
    }

    /// <summary>The get color from nom.</summary>
    /// <param name="nom">The nom.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="nom" /> is <see langword="null" />.</exception>
    /// <exception cref="FormatException">value does not comply with the input pattern specified by style.</exception>
    /// <exception cref="ArgumentException">
    ///     style is not a <see cref="System.Globalization.NumberStyles"></see> value. -or- style includes the
    ///     <see cref="System.Globalization.NumberStyles.AllowHexSpecifier"></see> or <see cref="System.Globalization.NumberStyles.HexNumber"></see> flag along with another value.
    /// </exception>
    public static string GetLightColorFromNom(string nom)
    {
        if (nom == null)
            throw new ArgumentNullException(nameof(nom));

        if (nom.Length == 3)
            return $"#{string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X", CultureInfo.CurrentCulture)))}";

        var s = string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X", CultureInfo.CurrentCulture)));
        var bi = BigInteger.Parse(s, NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture);
        var bii = bi % 0xFFFFFF;

        // On force des couleurs plus claire pour pouvoir l'utiliser comme fond
        bii |= 0xA0A0A0;

        var color = $"#{(long)bii:X6}";
        return color.Length != 7 ? "#000000" : color;
    }
}
