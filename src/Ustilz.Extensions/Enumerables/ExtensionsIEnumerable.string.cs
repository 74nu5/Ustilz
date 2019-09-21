namespace Ustilz.Extensions.Enumerables
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;

    #endregion

    /// <summary>The extensions i enumerable string.</summary>
    public static partial class ExtensionsIEnumerable
    {
        #region Méthodes publiques

        /// <summary>Returns a path combined out of the items in the given IEnumerable.</summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <returns>The combined path.</returns>
        [JetBrains.Annotations.PublicAPI]
        [Pure]
        [return: NotNull]
        public static string PathCombine([NotNull] [JetBrains.Annotations.ItemCanBeNull] this IEnumerable<string> enumerable)
        {
            enumerable.ThrowIfNull(nameof(enumerable));

            return Path.Combine(enumerable.ToArray());
        }

        #endregion
    }
}
