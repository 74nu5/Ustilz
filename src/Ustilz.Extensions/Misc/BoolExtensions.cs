namespace Ustilz.Extensions.Misc;

using JetBrains.Annotations;

/// <summary>The extensions bool.</summary>
[PublicAPI]
public static class BoolExtensions
{
    extension(bool b)
    {
        /// <summary>The as int.</summary>
        /// <returns>The <see cref="int" />.</returns>
        public int AsInt()
            => b ? 1 : 0;
    }
}
