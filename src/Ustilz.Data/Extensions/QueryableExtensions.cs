namespace Ustilz.Data.Extensions;

using System.Runtime.CompilerServices;

using CommunityToolkit.Diagnostics;

using JetBrains.Annotations;

using Microsoft.EntityFrameworkCore;

using Ustilz.Models;

/// <summary>
///     Extensions for <see cref="IQueryable{T}" />.
/// </summary>
[PublicAPI]
public static class QueryableExtensions
{
    /// <summary>
    ///     Tag a queryable with a debug info.
    /// </summary>
    /// <typeparam name="T">The type of the elements of <paramref name="queryable" />.</typeparam>
    /// <param name="queryable">The queryable to tag.</param>
    /// <param name="memberName">The member name. This parameter is optional and defaults to the name of the calling member.</param>
    /// <param name="sourceFilePath">The source file path. This parameter is optional and defaults to the file path of the caller.</param>
    /// <param name="sourceLineNumber">The source line number. This parameter is optional and defaults to the line number in the file of the caller.</param>
    /// <returns>The queryable tagged with the debug info.</returns>
    public static IQueryable<T> TagWithDebugInfo<T>(
        this IQueryable<T> queryable,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        var debugInfo = $"{sourceFilePath}:{sourceLineNumber} {memberName}";
        return queryable.TagWith($"/* {debugInfo} */");
    }

    /// <summary>
    ///     Paginate a queryable.
    /// </summary>
    /// <typeparam name="T">The type of the elements of <paramref name="queryable" />.</typeparam>
    /// <param name="queryable">The queryable to paginate.</param>
    /// <param name="page">The page number to return. Page numbers are 1-based, so the first page is page 1.</param>
    /// <param name="pageSize">The size of the page to return. Must be greater than 0.</param>
    /// <param name="orderBy">A function to order elements of the queryable. The function must return an <see cref="IOrderedQueryable{T}" />.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns>A <see cref="PageableResult{T}" /> that contains the elements of the current page and the total number of elements.</returns>
    public static async Task<PageableResult<T>> PaginateAsync<T>(
        this IQueryable<T> queryable,
        int page,
        int pageSize,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
        CancellationToken cancellationToken = default)
    {
        Guard.IsGreaterThan(page, 1);
        Guard.IsGreaterThan(pageSize, 0);

        queryable = orderBy(queryable);
        var items = await queryable.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken).ConfigureAwait(false);
        var totalElements = queryable.Count();
        return new(items, totalElements);
    }
}
