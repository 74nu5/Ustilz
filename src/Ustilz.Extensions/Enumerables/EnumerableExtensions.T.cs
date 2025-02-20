namespace Ustilz.Extensions.Enumerables;

#region Usings

using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;

using JetBrains.Annotations;

#endregion

/// <summary>The extensions i enumerable.</summary>
[PublicAPI]
public static partial class EnumerableExtensions
{
    /// <summary>
    ///     Method to adjust elements of an <see cref="IEnumerable{T}" />.
    /// </summary>
    /// <typeparam name="T">Type of enumerable element.</typeparam>
    /// <param name="enumerable">Enumerable to adjust.</param>
    /// <param name="shouldReplace">Condition for adjustment.</param>
    /// <param name="replacement">Replacement value.</param>
    /// <returns>Returns the initial list with adjustments.</returns>
    public static IEnumerable<T> Adjust<T>(this IEnumerable<T> enumerable, Func<T, int, bool> shouldReplace, T replacement) =>
            enumerable.Select((obj, pos) =>
                    shouldReplace(obj, pos)
                            ? replacement
                            : obj);

    /// <summary>
    ///     Method to split a list based on a boolean array.
    /// </summary>
    /// <typeparam name="T">Type of the list.</typeparam>
    /// <param name="items">List to split.</param>
    /// <param name="filter">Filter to apply.</param>
    /// <returns>Returns a tuple containing the two lists.</returns>
    public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(this IEnumerable<T> items,
                                                                                           IList<bool> filter)
    {
        ArgumentNullException.ThrowIfNull(items);
        ArgumentNullException.ThrowIfNull(filter);

        var enumerable = items.ToList();
        return (enumerable.Where((_, i) => filter[i]), enumerable.Where((_, i) => !filter[i]));
    }

    /// <summary>
    ///     Method to split a list based on a predicate.
    /// </summary>
    /// <typeparam name="T">Type of the list.</typeparam>
    /// <param name="items">List to split.</param>
    /// <param name="filter">Predicate to apply.</param>
    /// <returns>Returns a tuple containing the two lists.</returns>
    public static (IEnumerable<T> FilteredTrue, IEnumerable<T> FilteredFalse) Bifurcate<T>(this IEnumerable<T> items,
                                                                                           Func<T, bool> filter)
    {
        ArgumentNullException.ThrowIfNull(items);
        ArgumentNullException.ThrowIfNull(filter);

        var enumerable = items.ToList();
        return (enumerable.Where(filter), enumerable.Where(val => !filter(val)));
    }

    /// <summary>
    ///     Method to retrieve the element of the list for which the selector returns the maximum value.
    /// </summary>
    /// <typeparam name="T">Type of list elements.</typeparam>
    /// <typeparam name="TValue">Type of the value to compare. This must implement <see cref="IComparable{TValue}" />.</typeparam>
    /// <param name="list">List in which the search is performed.</param>
    /// <param name="selector">Comparison selector.</param>
    /// <returns>Returns the element of the list for which the selector returns the maximum value.</returns>
    public static T? FindMax<T, TValue>(this IEnumerable<T> list, Func<T, TValue> selector)
            where TValue : IComparable<TValue>
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(selector);

        var enumerable = list.ToList();
        var result = enumerable.FirstOrDefault();
        if (result == null)
            return default;

        var bestMax = selector(result);

        foreach (var item in enumerable.Skip(1))
        {
            var v = selector(item);
            if (v.CompareTo(bestMax) <= 0)
                continue;

            bestMax = v;
            result = item;
        }

        return result;
    }

    /// <summary>
    ///     Method to retrieve the element of the list for which the selector returns the minimum value.
    /// </summary>
    /// <typeparam name="T">Type of list elements.</typeparam>
    /// <typeparam name="TValue">Type of the value to compare. This must implement <see cref="IComparable{TValue}" />.</typeparam>
    /// <param name="list">List in which the search is performed.</param>
    /// <param name="selector">Comparison selector.</param>
    /// <returns>Returns the element of the list for which the selector returns the minimum value.</returns>
    public static T? FindMin<T, TValue>(this IEnumerable<T> list, Func<T, TValue> selector)
            where TValue : IComparable<TValue>
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(selector);

        var enumerable = list.ToList();
        var result = enumerable.FirstOrDefault();
        if (result == null)
            return default;

        var bestMin = selector(result);

        foreach (var item in enumerable.Skip(1))
        {
            var v = selector(item);
            if (v.CompareTo(bestMin) >= 0)
                continue;

            bestMin = v;
            result = item;
        }

        return result;
    }

    /// <summary>
    ///     Enumerate each element in the enumeration and execute specified action.
    /// </summary>
    /// <typeparam name="T">Type of enumeration.</typeparam>
    /// <param name="enumerable">Enumerable collection.</param>
    /// <param name="action">Action to perform.</param>
    public static void ForEach<T>(this IEnumerable<T> enumerable,
                                  Action<T> action)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));
        _ = enumerable ?? throw new ArgumentNullException(nameof(enumerable));

        foreach (var item in enumerable)
            action(item);
    }

    /// <summary>
    ///     The join.
    /// </summary>
    /// <param name="tab">The tab. </param>
    /// <param name="separator">The separator. </param>
    /// <typeparam name="T">The type. </typeparam>
    /// <returns>The <see cref="string" />. </returns>
    public static string Join<T>(this IEnumerable<T> tab, string separator)
        => string.Join(separator, tab);

    /// <summary>
    ///     Determines whether the given IEnumerable contains no items, or not.
    /// </summary>
    /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
    /// <param name="enumerable">The IEnumerable to check.</param>
    /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
    /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
    [PublicAPI]
    public static bool NotAny<T>(this IEnumerable<T?> enumerable)
    {
        ArgumentNullException.ThrowIfNull(enumerable);

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
    [PublicAPI]
    public static bool NotAny<T>(this IEnumerable<T> enumerable,
                                 Func<T, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(predicate);
        ArgumentNullException.ThrowIfNull(enumerable);

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
        => page < 1 || pageSize < 1
                   ? throw new ArgumentException(Messages.MustBeOneOrGreater, page < 1 ? "page" : "pageSize")
                   : source.Skip(--page * pageSize).Take(pageSize);

    /// <summary>
    ///     Method to process elements of a list pairwise.
    /// </summary>
    /// <param name="source">Source list.</param>
    /// <param name="selector">Method to calculate elements pairwise.</param>
    /// <typeparam name="T">Type of list elements.</typeparam>
    /// <typeparam name="TReturn">Return type of the pairwise calculation.</typeparam>
    /// <returns>Returns a list containing the results of the pairwise element calculations.</returns>
    /// <exception cref="ArgumentNullException">Throws an exception if any of the arguments are null.</exception>
    /// <exception cref="InvalidOperationException">Throws an exception if the list is empty.</exception>
    /// <exception cref="InvalidOperationException">Throws an exception if the list contains less than two elements.</exception>
    public static IEnumerable<TReturn> Pairwise<T, TReturn>(this IEnumerable<T> source, Func<T, T, TReturn> selector)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(selector);

        using var e = source.GetEnumerator();
        if (!e.MoveNext())
            throw new InvalidOperationException("Sequence cannot be empty.");

        var prev = e.Current;

        if (!e.MoveNext())
            throw new InvalidOperationException("Sequence must contain at least two elements.");

        do
        {
            yield return selector(prev, e.Current);
            prev = e.Current;
        }
        while (e.MoveNext());
    }

    /// <summary>
    ///     Method to split a list into n lists.
    /// </summary>
    /// <typeparam name="T">Type of the list.</typeparam>
    /// <param name="enumerable">List to split.</param>
    /// <param name="split">Number of lists.</param>
    /// <returns>Returns a split list.</returns>
    public static IEnumerable<IEnumerable<T>> SplitList<T>(IEnumerable<T> enumerable, int split)
    {
        var list = enumerable.ToList();
        var count = list.Count;
        var subN = count / split;
        for (var i = 0; i < count; i += subN)
            yield return list.Skip(i).Take(subN);
    }

    /// <summary>
    ///     Read only collection of any enumeration.
    /// </summary>
    /// <typeparam name="T">Type of enumeration.</typeparam>
    /// <param name="collection">Enumerable collection.</param>
    /// <returns>ReadOnlyCollection of the collection.</returns>
    public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection)
        => new List<T>(collection).AsReadOnly();

    /// <summary>
    ///     Method to retrieve an enumeration with index.
    /// </summary>
    /// <typeparam name="T">Type of the list.</typeparam>
    /// <param name="enumerable">Enumerable to process.</param>
    /// <returns>Returns an enumerable containing <see cref="Tuple" />, representing a pair (item, index).</returns>
    public static IEnumerable<(T Item, int Index)> WithIndex<T>(this IEnumerable<T> enumerable)
        => enumerable.Select((item, index) => (item, index));

    /// <summary>
    ///     Converts a list of objects to a <see cref="DataTable" />.
    /// </summary>
    /// <typeparam name="T">The type of object to convert.</typeparam>
    /// <param name="items">The list of objects to convert.</param>
    /// <param name="withParentProperties">
    ///     Indicates whether parent properties should be included in the conversion.
    ///     <remarks>
    ///         Only if <typeparamref name="T" /> is an interface.
    ///     </remarks>
    /// </param>
    /// <returns>The <see cref="DataTable" /> containing the data from the list of objects.</returns>
    public static DataTable ToDataTable<T>(this IEnumerable<T> items, bool withParentProperties = true)
            where T : notnull
    {
        ArgumentNullException.ThrowIfNull(items);

        var itemsArray = items.ToArray();
        var type = typeof(T);

        var dataTable = new DataTable(type.Name);

        var properties = (type.IsInterface, withParentProperties) switch
        {
            (true, true) => [.. GetProperties(type)],
            (_, _) => type.GetProperties(BindingFlags.Public | BindingFlags.Instance),
        };

        foreach (var prop in properties)
            _ = dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        foreach (var item in itemsArray)
        {
            var values = new object?[properties.Length];

            for (var i = 0; i < properties.Length; i++)
                values[i] = properties[i].GetValue(item, null);

            _ = dataTable.Rows.Add(values);
        }

        return dataTable;
    }

    private static List<PropertyInfo> GetProperties(Type type)
    {
        if (!type.IsInterface)
            throw new ArgumentException(@"Type must be an interface", nameof(type));

        var properties = new List<PropertyInfo>();

        properties.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance));

        foreach (var interfaceType in type.GetInterfaces())
            properties.AddRange(GetProperties(interfaceType));

        return properties;
    }
}
