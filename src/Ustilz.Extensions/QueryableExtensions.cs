namespace Ustilz.Extensions;

using CommunityToolkit.Diagnostics;

using JetBrains.Annotations;

using Ustilz.Models;

/// <summary>
///     Extensions for <see cref="IQueryable{T}" />.
/// </summary>
[PublicAPI]
public static class QueryableExtensions
{
    /// <summary>
    ///     Paginate a queryable.
    /// </summary>
    /// <typeparam name="T">The type of the elements of <paramref name="queryable" />.</typeparam>
    /// <param name="queryable">The queryable to paginate.</param>
    /// <param name="page">The page number to return. Page numbers are 1-based, so the first page is page 1.</param>
    /// <param name="pageSize">The size of the page to return. Must be greater than 0.</param>
    /// <param name="orderBy">A function to order elements of the queryable. The function must return an <see cref="IOrderedQueryable{T}" />.</param>
    /// <returns>A <see cref="PageableResult{T}" /> that contains the elements of the current page and the total number of elements.</returns>
    public static PageableResult<T> Paginate<T>(
        this IQueryable<T> queryable,
        int page,
        int pageSize,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
    {
        Guard.IsGreaterThan(page, 1);
        Guard.IsGreaterThan(pageSize, 0);

        queryable = orderBy(queryable);
        var items = queryable.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        var totalElements = queryable.Count();
        return new(items, totalElements);
    }
}
