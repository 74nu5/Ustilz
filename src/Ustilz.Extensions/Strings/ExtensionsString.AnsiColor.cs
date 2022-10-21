namespace Ustilz.Extensions.Strings;

public static partial class ExtensionsString
{
    /// <summary>
    ///     The console black color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Black(this string text)
        => $"[30m{text}[39m";

    /// <summary>
    ///     The console blue color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Blue(this string text)
        => $"[34m{text}[39m";

    /// <summary>
    ///     The console bold transformation.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Bold(this string text)
        => $"[1m{text}[22m";

    /// <summary>
    ///     The console cyan color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Cyan(this string text)
        => $"[36m{text}[39m";

    /// <summary>
    ///     The console green color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Green(this string text)
        => $"[32m{text}[39m";

    /// <summary>
    ///     The console magenta color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Magenta(this string text)
        => $"[35m{text}[39m";

    /// <summary>
    ///     The console red color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Red(this string text)
        => $"[31m{text}[39m";

    /// <summary>
    ///     The console white color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string White(this string text)
        => $"[37m{text}[39m";

    /// <summary>
    ///     The console yellow color.
    /// </summary>
    /// <param name="text">The text to color.</param>
    /// <returns>Returns the colored text.</returns>
    public static string Yellow(this string text)
        => $"[33m{text}[39m";
}
