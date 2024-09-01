namespace Ustilz.Wtf;

using JetBrains.Annotations;

/// <summary>
///     Class which contains methods which bring back the good old days.
/// </summary>
[PublicAPI]
public static class Nostalgia
{
    /// <summary>
    ///     Convert a text to Nokia 3310 format.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The text in Nokia 3310 format.</returns>
    public static string To3310(string text)
    {
        return text.Aggregate(string.Empty, (current, c) => current + CharTo3310(c));

        static string CharTo3310(char c)
            => c switch
            {
                'a' or 'A' => "2",
                'b' or 'B' => "22",
                'c' or 'C' => "222",
                'd' or 'D' => "3",
                'e' or 'E' => "33",
                'f' or 'F' => "333",
                'g' or 'G' => "4",
                'h' or 'H' => "44",
                'i' or 'I' => "444",
                'j' or 'J' => "5",
                'k' or 'K' => "55",
                'l' or 'L' => "555",
                'm' or 'M' => "6",
                'n' or 'N' => "66",
                'o' or 'O' => "666",
                'p' or 'P' => "7",
                'q' or 'Q' => "77",
                'r' or 'R' => "777",
                's' or 'S' => "7777",
                't' or 'T' => "8",
                'u' or 'U' => "88",
                'v' or 'V' => "888",
                'w' or 'W' => "9",
                'x' or 'X' => "99",
                'y' or 'Y' => "999",
                'z' or 'Z' => "9999",
                ' ' => "0",
                '.' => "00",
                _ => string.Empty,
            };
    }
}
