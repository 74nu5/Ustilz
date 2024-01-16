namespace Ustilz.Extensions.Misc;

using JetBrains.Annotations;

/// <summary>The extensions bool.</summary>
[PublicAPI]
public static class BoolExtensions
{
    /// <summary>The as int.</summary>
    /// <param name="b">The b.</param>
    /// <returns>The <see cref="int" />.</returns>
    public static int AsInt(this bool b)
        => b ? 1 : 0;
}
