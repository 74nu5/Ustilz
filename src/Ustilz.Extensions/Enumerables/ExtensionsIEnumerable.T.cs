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
    public static partial class ExtensionsIEnumerable
    {
        /// <summary>
        ///     Méthode permettant d'ajuster des éléments d'un <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <typeparam name="T">Type d'élément de l'énumérable.</typeparam>
        /// <param name="enumerable">Enumérable à ajuster.</param>
        /// <param name="shouldReplace">Condition de d'ajustement.</param>
        /// <param name="replacement">Valeur de remplacement.</param>
        /// <returns>Retourne la liste initiale avec les ajustements.</returns>
        public static IEnumerable<T> Adjust<T>(this IEnumerable<T> enumerable, Func<T, int, bool> shouldReplace, T replacement) =>
            enumerable.Select(
                (obj, pos) =>
                    shouldReplace(obj, pos)
                        ? replacement
                        : obj);

        /// <summary>
        ///     Méthode qui split une liste à partir d'un tableau de booléen.
        /// </summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="items">Liste à spliter.</param>
        /// <param name="filter">Filtre à appliquer.</param>
        /// <returns>Retourne un tuple contenant les deux listes.</returns>
        public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(this IEnumerable<T> items, IList<bool> filter)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (filter is null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var enumerable = items.ToList();
            return (enumerable.Where((val, i) => filter[i]), enumerable.Where((val, i) => !filter[i]));
        }

        /// <summary>
        ///     Méthode qui split une liste à partir d'un prédicat.
        /// </summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="items">Liste à spliter.</param>
        /// <param name="filter">Prédicat à appliquer.</param>
        /// <returns>Retourne un tuple contenant les deux listes.</returns>
        public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(this IEnumerable<T> items, Func<T, bool> filter)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (filter is null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var enumerable = items.ToList();
            return (enumerable.Where(filter), enumerable.Where(val => !filter(val)));
        }

        /// <summary>Enumerate each element in the enumeration and execute specified action.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="enumerable">Enumerable collection.</param>
        /// <param name="action">Action to perform.</param>
        public static void ForEach<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this IEnumerable<T> enumerable,
            Action<T> action)
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
        [System.Diagnostics.Contracts.Pure]
        [PublicAPI]
        public static bool NotAny<T>(
            [System.Diagnostics.CodeAnalysis.NotNull] [ItemCanBeNull]
            this IEnumerable<T> enumerable)
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
        [System.Diagnostics.Contracts.Pure]
        [PublicAPI]
        public static bool NotAny<T>(
            [System.Diagnostics.CodeAnalysis.NotNull] [ItemCanBeNull]
            this IEnumerable<T> enumerable,
            [System.Diagnostics.CodeAnalysis.NotNull]
            Func<T, bool> predicate)
        {
            enumerable.ThrowIfNull(nameof(enumerable));
            predicate.ThrowIfNull(nameof(predicate));

            return !enumerable.Any(predicate);
        }

        /// <summary>
        ///     Gets a subset of IEnumerable by passing the page number.
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
                throw new ArgumentException(Messages.MustBeOneOrGreater, page < 1 ? "page" : "pageSize");
            }

            return source.Skip(--page * pageSize).Take(pageSize);
        }

        /// <summary>Read only collection of any enumeration.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="collection">Enumerable collection.</param>
        /// <returns>ReadOnlyCollection of the collection.</returns>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection)
            => new List<T>(collection).AsReadOnly();

        /// <summary>
        ///     Méthode récupération d'une énumération avec index.
        /// </summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="enumerable">Enumérable à traiter.</param>
        /// <returns>Retourne un énumarable contenant des <see cref="Tuple" />, représentant un couple (item, index0).</returns>
        public static IEnumerable<(T Item, int Index)> WithIndex<T>(this IEnumerable<T> enumerable)
            => enumerable.Select((item, index) => (item, index));

        /// <summary>
        ///     Méthode de split d'un liste en n liste.
        /// </summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="enumerable">Liste à spliter.</param>
        /// <param name="split">Nombre de liste.</param>
        /// <returns>Retourne une liste splité.</returns>
        public static IEnumerable<IEnumerable<T>> SplitList<T>(IEnumerable<T> enumerable, int split)
        {
            var list = enumerable.ToList();
            var count = list.Count;
            var subN = count / split;
            for (var i = 0; i < count; i += subN)
            {
                yield return list.Skip(i).Take(subN);
            }
        }
    }
}
