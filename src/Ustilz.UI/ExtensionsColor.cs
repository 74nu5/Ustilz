namespace Ustilz.UI;

using System.Drawing;

using JetBrains.Annotations;

/// <summary>
/// Classe statique d'extension de la classe <see cref="Color"/>.
/// </summary>
[PublicAPI]
public static class ExtensionsColor
{
    /// <summary>
    /// Méthode qui retourne une coleur contrastante par rapport à celle passée en paramètre pour rendre un texte affichable.
    /// </summary>
    /// <param name="value">Couleur à contraster.</param>
    /// <returns>Retourne une coleur contrastante par rapport à celle passée en paramètre.</returns>
    public static Color GetContrastingColor(this Color value)
    {
        // Counting the perceptive luminance - human eye favors green color...
        var a = 1 - (((0.299 * value.R) + (0.587 * value.G) + (0.114 * value.B)) / 255);
        var d = a < 0.5 ? 0 : 255;

        return Color.FromArgb(d, d, d);
    }
}