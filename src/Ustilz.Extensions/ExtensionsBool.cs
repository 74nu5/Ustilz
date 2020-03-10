namespace Ustilz.Extensions
{
    #region Usings

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions bool.</summary>
    [PublicAPI]
    public static class ExtensionsBool
    {
        /// <summary>The as int.</summary>
        /// <param name="b">The b.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int AsInt(this bool b)
            => b ? 1 : 0;
    }
}
