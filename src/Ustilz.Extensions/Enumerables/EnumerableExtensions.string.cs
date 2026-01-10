namespace Ustilz.Extensions.Enumerables;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using JetBrains.Annotations;

/// <summary>The extensions i enumerable string.</summary>
public static partial class EnumerableExtensions
{
    extension(IEnumerable<string> enumerable)
    {
        /// <summary>Returns a path combined out of the items in the given IEnumerable.</summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <returns>The combined path.</returns>
        [PublicAPI]
        public string PathCombine()
        {
            _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));

            return Path.Combine(enumerable.ToArray());
        }
    }
}