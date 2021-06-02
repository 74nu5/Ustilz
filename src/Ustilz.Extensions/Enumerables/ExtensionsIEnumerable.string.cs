namespace Ustilz.Extensions.Enumerables
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using JetBrains.Annotations;

    /// <summary>The extensions i enumerable string.</summary>
    public static partial class ExtensionsIEnumerable
    {
        /// <summary>Returns a path combined out of the items in the given IEnumerable.</summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <returns>The combined path.</returns>
        [PublicAPI]
        
        public static string PathCombine(this IEnumerable<string> enumerable)
        {
            _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));

            return Path.Combine(enumerable.ToArray());
        }
    }
}
