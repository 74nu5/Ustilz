namespace Ustilz.Extensions.Enumerables
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions i enumerable.</summary>
    [PublicAPI]
    public static class ExtensionsIEnumerableT
    {
        #region Méthodes publiques

        /// <summary>Enumerate each element in the enumeration and execute specified action</summary>
        /// <typeparam name="T">Type of enumeration</typeparam>
        /// <param name="enumerable">Enumerable collection</param>
        /// <param name="action">Action to perform</param>
        public static void ForEach<T>([NotNull] this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        /// <summary>Read only collection of any enumeration</summary>
        /// <typeparam name="T">Type of enumeration</typeparam>
        /// <param name="collection">Enumerable collection</param>
        /// <returns>ReadOnlyCollection of the collection</returns>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection) => new List<T>(collection).AsReadOnly();

        /// <summary>
        ///     Determines whether the given IEnumerable contains no items, or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean NotAny<T>([NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable)
        {
            enumerable.ThrowIfNull(nameof(enumerable));

            return !enumerable.Any();
        }

        /// <summary>
        ///     Determines whether the given IEnumerable contains no items matching the given predicate, or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <param name="predicate">The predicate.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean NotAny<T>([NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, Boolean> predicate)
        {
            enumerable.ThrowIfNull(nameof(enumerable));
            predicate.ThrowIfNull(nameof(predicate));

            return !enumerable.Any(predicate);
        }

        #endregion
    }
}
