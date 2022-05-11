namespace Ustilz.Data.AccessLayer.Queries;

using JetBrains.Annotations;

using Ustilz.Data.AccessLayer.Queries.Abstractions;
using Ustilz.Data.AccessLayer.Queries.Pageable;
using Ustilz.Data.Entities;

/// <summary>
///     Abstraction that provides basic CRUD operations on models data.
/// </summary>
/// <typeparam name="TContext">The context to query.</typeparam>
/// <typeparam name="TEntity">The entity type to query.</typeparam>
/// <typeparam name="TQueryDto">The query type.</typeparam>
/// <typeparam name="TIdentity">The primary key type.</typeparam>
[PublicAPI]
public abstract class AQueryBaseAccessLayer<TContext, TEntity, TQueryDto, TIdentity>
    : ABaseAccessLayer<TContext, TEntity, TIdentity>, IQueryBaseAccessLayer<TEntity, TQueryDto, TIdentity>
    where TEntity : ADataObject<TIdentity>
    where TContext : ADbContext
    where TIdentity : IComparable<TIdentity>
    where TQueryDto : PageableQuery
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AQueryBaseAccessLayer{TContext, TEntity,TQueryDto, TIdentity}" /> class.
    /// </summary>
    /// <param name="context">The context.</param>
    protected AQueryBaseAccessLayer(TContext context)
        : base(context)
    {
    }

    /// <inheritdoc />
    public async Task<int> CountCollectionAsync(TQueryDto query)
        => (await this.GetCollectionInternalAsync(query, false)).Count();

    /// <inheritdoc />
    public Task<IEnumerable<TEntity>> GetCollectionAsync(TQueryDto query, bool isPageable = true)
        => this.GetCollectionInternalAsync(query, isPageable);

    /// <inheritdoc />
    public async Task<PageableResult<TEntity>> GetPageableCollectionAsync(TQueryDto query, bool isPageable = true)
        => new(await this.GetCollectionInternalAsync(query, isPageable), (await this.GetCollectionInternalAsync(query, false)).Count());

    /// <summary>
    ///     Internal method that retrieve a queryable collection of data according to the query.
    /// </summary>
    /// <param name="query">Query object to filter data.</param>
    /// <param name="isPageable">Boolean that determines if the result is paged.</param>
    /// <returns>Returns the queryable list of entity.</returns>
    protected abstract Task<IEnumerable<TEntity>> GetCollectionInternalAsync(TQueryDto query, bool isPageable = true);
}
