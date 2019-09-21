namespace Ustilz.Extensions.Enumerables
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.Linq;

    #endregion

    /// <summary>The extensions i enumerable.</summary>
    [JetBrains.Annotations.PublicAPI]
    public static partial class ExtensionsIEnumerable
    {
        #region Méthodes publiques

        /// <summary>Enumerate each element in the enumeration and execute specified action.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="enumerable">Enumerable collection.</param>
        /// <param name="action">Action to perform.</param>
        public static void ForEach<T>([NotNull] this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable is null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        /// <summary>The join. </summary>
        /// <param name="tab">The tab. </param>
        /// <param name="separateur">The separateur. </param>
        /// <typeparam name="T">The type. </typeparam>
        /// <returns>The <see cref="string" />. </returns>
        public static string Join<T>(this IEnumerable<T> tab, string separateur)
            => string.Join(separateur, tab);

        /// <summary>Determines whether the given IEnumerable contains no items, or not.</summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [JetBrains.Annotations.PublicAPI]
        public static bool NotAny<T>([NotNull] [JetBrains.Annotations.ItemCanBeNull] this IEnumerable<T> enumerable)
        {
            enumerable.ThrowIfNull(nameof(enumerable));

            return !enumerable.Any();
        }

        /// <summary>Determines whether the given IEnumerable contains no items matching the given predicate, or not.</summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <param name="predicate">The predicate.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [JetBrains.Annotations.PublicAPI]
        public static bool NotAny<T>([NotNull] [JetBrains.Annotations.ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, bool> predicate)
        {
            enumerable.ThrowIfNull(nameof(enumerable));
            predicate.ThrowIfNull(nameof(predicate));

            return !enumerable.Any(predicate);
        }

        /// <summary>Read only collection of any enumeration.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="collection">Enumerable collection.</param>
        /// <returns>ReadOnlyCollection of the collection.</returns>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection)
            => new List<T>(collection).AsReadOnly();

        /// <summary>
        /// Gets a subset of IEnumerable by passing the page number.
        /// </summary>
        /// <typeparam name="T">Type of enumerable.</typeparam>
        /// <param name="source">Enumerable source.</param>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Return a subset of IEnumerable by passing the page number.</returns>
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int page, int pageSize)
        {
            if (page < 1 || pageSize < 1)
            {
                throw new ArgumentException(Strings.MustBeOneOrGreater, page < 1 ? "page" : "pageSize");
            }

            return source.Skip(--page * pageSize).Take(pageSize);
        }

        #endregion
    }
}
