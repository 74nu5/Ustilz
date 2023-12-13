namespace Ustilz.Extensions.Enumerables;

using System;
using System.Collections.Generic;
using System.Linq;

using Ustilz.Extensions.Strings;

/// <summary>The extensions i enumerable.</summary>
public static partial class ExtensionsIEnumerable
{
    /// <summary>Converts bytes collection to hexadecimal representation.</summary>
    /// <param name="bytes">Bytes to convert.</param>
    /// <returns>Hexadecimal representation string.</returns>
    public static string ToHexString(this IEnumerable<byte> bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);

        return string.Join(string.Empty, bytes.Select(b => $"0{b:X}".Right(2)));
    }
}