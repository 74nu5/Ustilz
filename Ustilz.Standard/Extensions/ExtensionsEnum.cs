namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions enum.</summary>
    [PublicAPI]
    public static class ExtensionsEnum
    {
        #region Méthodes publiques

        /// <summary>
        ///     Returns true if enum matches any of the given values
        /// </summary>
        /// <param name="value">Value to match</param>
        /// <param name="values">Values to match against</param>
        /// <returns>Return true if matched</returns>
        public static bool In(this Enum value, params Enum[] values) => values.Any(v => ReferenceEquals(v, value));

        #endregion
    }
}
