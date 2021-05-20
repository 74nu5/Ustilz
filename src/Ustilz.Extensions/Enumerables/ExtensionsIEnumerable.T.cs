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
        #region Méthodes publiques

        /// <summary>Méthode permettant d'ajuster des éléments d'un <see cref="IEnumerable{T}" />.</summary>
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

        /// <summary>Méthode qui split une liste à partir d'un tableau de booléen.</summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="items">Liste à spliter.</param>
        /// <param name="filter">Filtre à appliquer.</param>
        /// <returns>Retourne un tuple contenant les deux listes.</returns>
        public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this IEnumerable<T> items,
            [System.Diagnostics.CodeAnalysis.NotNull]
            IList<bool> filter)
        {
            _ = filter ?? throw new ArgumentNullException(nameof(filter));
            _ = items ?? throw new ArgumentNullException(nameof(items));

            var enumerable = items.ToList();
            return (enumerable.Where((_, i) => filter[i]), enumerable.Where((_, i) => !filter[i]));
        }

        /// <summary>Méthode qui split une liste à partir d'un prédicat.</summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="items">Liste à spliter.</param>
        /// <param name="filter">Prédicat à appliquer.</param>
        /// <returns>Retourne un tuple contenant les deux listes.</returns>
        public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this IEnumerable<T> items,
            [System.Diagnostics.CodeAnalysis.NotNull]
            Func<T, bool> filter)
        {
            _ = filter ?? throw new ArgumentNullException(nameof(filter));
            _ = items ?? throw new ArgumentNullException(nameof(items));

            var enumerable = items.ToList();
            return (enumerable.Where(filter), enumerable.Where(val => !filter(val)));
        }

        /// <summary>Méthode de récupération de l'élément de la liste pour lequel le sélecteur renvoie la valeur maximale.</summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <typeparam name="TValue">Type de la valeur à comparer. Celui-ci doit implémenter <see cref="IComparable{TValue}" />.</typeparam>
        /// <param name="list">Liste dans laquelle la recherche est effectuée.</param>
        /// <param name="selector">Selecteur de comparaison.</param>
        /// <returns>Retourne de l'élément de la liste pour lequel le sélecteur renvoie la valeur maximale.</returns>
        public static T? FindMax<T, TValue>(this IEnumerable<T> list, Func<T, TValue> selector)
            where TValue : IComparable<TValue>
        {
            var enumerable = list.ToList();
            var result = enumerable.FirstOrDefault();
            if (result == null)
            {
                return default;
            }

            var bestMax = selector(result);
            foreach (var item in enumerable.Skip(1))
            {
                var v = selector(item);
                if (v.CompareTo(bestMax) <= 0)
                {
                    continue;
                }

                bestMax = v;
                result = item;
            }

            return result;
        }

        /// <summary>Méthode de récupération de l'élément de la liste pour lequel le sélecteur renvoie la valeur minimale.</summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <typeparam name="TValue">Type de la valeur à comparer. Celui-ci doit implémenter <see cref="IComparable{TValue}" />.</typeparam>
        /// <param name="list">Liste dans laquelle la recherche est effectuée.</param>
        /// <param name="selector">Selecteur de comparaison.</param>
        /// <returns>Retourne de l'élément de la liste pour lequel le sélecteur renvoie la valeur minimale.</returns>
        public static T? FindMin<T, TValue>(this IEnumerable<T> list, Func<T, TValue> selector)
            where TValue : IComparable<TValue>
        {
            var enumerable = list.ToList();
            var result = enumerable.FirstOrDefault();
            if (result == null)
            {
                return default;
            }

            var bestMin = selector(result);
            foreach (var item in enumerable.Skip(1))
            {
                var v = selector(item);
                if (v.CompareTo(bestMin) >= 0)
                {
                    continue;
                }

                bestMin = v;
                result = item;
            }

            return result;
        }

        /// <summary>Enumerate each element in the enumeration and execute specified action.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="enumerable">Enumerable collection.</param>
        /// <param name="action">Action to perform.</param>
        public static void ForEach<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this IEnumerable<T> enumerable,
            [System.Diagnostics.CodeAnalysis.NotNull]
            Action<T> action)
        {
            _ = action ?? throw new ArgumentNullException(nameof(action));
            _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));

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
            _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));
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
            [ItemCanBeNull] this IEnumerable<T> enumerable,
            Func<T, bool> predicate)
        {
            _ = predicate ?? throw new ArgumentNullException(nameof(predicate));
            _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));

            return !enumerable.Any(predicate);
        }

        /// <summary>Gets a subset of IEnumerable by passing the page number.</summary>
        /// <typeparam name="T">Type of enumerable.</typeparam>
        /// <param name="source">Enumerable source.</param>
        /// <param name="page">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Return a subset of IEnumerable by passing the page number.</returns>
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int page, int pageSize)
            => page < 1 || pageSize < 1
                   ? throw new ArgumentException(Messages.MustBeOneOrGreater, page < 1 ? "page" : "pageSize")
                   : source.Skip(--page * pageSize).Take(pageSize);

        /// <summary>Méthode de traitement des éléments d'une liste deux à deux.</summary>
        /// <param name="source">Liste source.</param>
        /// <param name="selector">Méthode de calcul des éléments deux à deux.</param>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <typeparam name="TReturn">Type du retour du calcul des éléments deux à deux.</typeparam>
        /// <returns>Retourne une liste contenant les résultat des calcul des éléments deux à deux.</returns>
        /// <exception cref="ArgumentNullException">Lève une exception si un des arguments est null.</exception>
        /// <exception cref="InvalidOperationException">Lève une exception si la liste est vide.</exception>
        /// <exception cref="InvalidOperationException">Lève une exception si la liste contient moins de deux éléménts.</exception>
        public static IEnumerable<TReturn> Pairwise<T, TReturn>(this IEnumerable<T> source, Func<T, T, TReturn> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            using var e = source.GetEnumerator();
            if (!e.MoveNext())
            {
                throw new InvalidOperationException("Sequence cannot be empty.");
            }

            var prev = e.Current;

            if (!e.MoveNext())
            {
                throw new InvalidOperationException("Sequence must contain at least two elements.");
            }

            do
            {
                yield return selector(prev, e.Current);
                prev = e.Current;
            }
            while (e.MoveNext());
        }

        /// <summary>Méthode de split d'un liste en n liste.</summary>
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

        /// <summary>Read only collection of any enumeration.</summary>
        /// <typeparam name="T">Type of enumeration.</typeparam>
        /// <param name="collection">Enumerable collection.</param>
        /// <returns>ReadOnlyCollection of the collection.</returns>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection)
            => new List<T>(collection).AsReadOnly();

        /// <summary>Méthode récupération d'une énumération avec index.</summary>
        /// <typeparam name="T">Type de la liste.</typeparam>
        /// <param name="enumerable">Enumérable à traiter.</param>
        /// <returns>Retourne un énumarable contenant des <see cref="Tuple" />, représentant un couple (item, index0).</returns>
        public static IEnumerable<(T Item, int Index)> WithIndex<T>(this IEnumerable<T> enumerable)
            => enumerable.Select((item, index) => (item, index));

        #endregion
    }
}
