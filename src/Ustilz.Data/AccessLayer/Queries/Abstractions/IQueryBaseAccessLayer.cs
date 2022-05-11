namespace Ustilz.Data.AccessLayer.Queries.Abstractions;

using JetBrains.Annotations;

using Ustilz.Data.AccessLayer.Abstractions;
using Ustilz.Data.AccessLayer.Queries.Pageable;
using Ustilz.Data.Entities;

/// <summary>
///     Interface which represent the query base access layer.
/// </summary>
/// <typeparam name="TEntity">The entity type to query.</typeparam>
/// <typeparam name="TQueryDto">The query type.</typeparam>
/// <typeparam name="TIdentity">The primary key type.</typeparam>
[PublicAPI]
public interface IQueryBaseAccessLayer<TEntity, in TQueryDto, TIdentity> : IBaseAccessLayer<TEntity, TIdentity>
    where TEntity : ADataObject<TIdentity>
    where TIdentity : IComparable<TIdentity>
    where TQueryDto : PageableQuery

{
    /// <summary>
    ///     Method that retrieve the count of collection of data according to the query.
    /// </summary>
    /// <param name="query">Query object to filter data.</param>
    /// <returns>Returns the result count item according the query.</returns>
    Task<int> CountCollectionAsync(TQueryDto query);

    /// <summary>
    ///     Method that retrieve a collection of data according to the query.
    /// </summary>
    /// <param name="query">Query object to filter data.</param>
    /// <param name="isPageable">Boolean that determines if the result is paged.</param>
    /// <returns>Returns the collection result of query.</returns>
    Task<IEnumerable<TEntity>> GetCollectionAsync(TQueryDto query, bool isPageable = true);

    /// <summary>
    ///     Method that retrieve a pageable collection of data according to the query.
    /// </summary>
    /// <param name="query">Query object to filter data.</param>
    /// <param name="isPageable">Boolean that determines if the result is paged.</param>
    /// <returns>Returns the pageable collection result of query.</returns>
    Task<PageableResult<TEntity>> GetPageableCollectionAsync(TQueryDto query, bool isPageable = true);
}
