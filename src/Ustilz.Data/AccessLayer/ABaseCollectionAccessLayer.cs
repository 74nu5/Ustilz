namespace Ustilz.Data.AccessLayer;

using System.Linq.Expressions;

using JetBrains.Annotations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using Ustilz.Data.AccessLayer.Abstractions;

/// <summary>
///     Provides a base implementation for access layer.
/// </summary>
/// <typeparam name="TContext">Type context type.</typeparam>
/// <typeparam name="TEntity">Type entity type.</typeparam>
[PublicAPI]
public abstract class ABaseCollectionAccessLayer<TContext, TEntity> : IBaseCollectionAccessLayer<TEntity>
        where TContext : ADbContext
        where TEntity : class
{
    /// <summary>
    ///     The sql insensitive collation.
    /// </summary>
    protected const string SQLCollationInsensitive = "SQL_Latin1_General_CP1_CI_AI";

    /// <summary>
    ///     Initializes a new instance of the <see cref="ABaseAccessLayer{TContext, TEntity, TIdentity}" /> class.
    /// </summary>
    /// <param name="context">The DB context.</param>
    protected ABaseCollectionAccessLayer(TContext context)
    {
        this.Context = context;
        this.ModelSet = this.Context.Set<TEntity>();
    }

    /// <summary>
    ///     Gets the Db context.
    /// </summary>
    protected TContext Context { get; }

    /// <summary>
    ///     Gets the Db model set.
    /// </summary>
    protected DbSet<TEntity> ModelSet { get; }

    /// <inheritdoc />
    public async Task<int> AddRangeAsync(IEnumerable<TEntity> models)
    {
        this.ModelSet.AddRange(models);
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }

    /// <inheritdoc />
    public IQueryable<TEntity> GetCollection(
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null)
    {
        var dbQuery = this.ModelSet.AsQueryable();

        if (navigationProperties != null)
            dbQuery = navigationProperties(dbQuery);

        if (filter != null)
            dbQuery = dbQuery.Where(filter);

        var collection = trackingEnabled
                                 ? dbQuery
                                 : dbQuery.AsNoTracking();

        return collection;
    }

    /// <inheritdoc />
    public IQueryable<TResult> GetCollection<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null)
    {
        var dbQuery = this.ModelSet.AsQueryable();

        if (navigationProperties != null)
            dbQuery = navigationProperties(dbQuery);

        if (filter != null)
            dbQuery = dbQuery.Where(filter);

        var collection = trackingEnabled
                                 ? dbQuery.Select(selector)
                                 : dbQuery.AsNoTracking().Select(selector);

        return collection;
    }

    /// <inheritdoc />
    public async Task<TEntity?> GetSingleAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null)
    {
        var dbQuery = this.ModelSet.AsQueryable();

        if (navigationProperties != null)
            dbQuery = navigationProperties(dbQuery);

        if (filter != null)
            dbQuery = dbQuery.Where(filter);

        var item = trackingEnabled
                           ? await dbQuery.FirstOrDefaultAsync()
                           : await dbQuery.AsNoTracking().FirstOrDefaultAsync();

        return item;
    }

    /// <inheritdoc />
    public async Task<TResult?> GetSingleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null)
    {
        var dbQuery = this.ModelSet.AsQueryable();

        if (navigationProperties != null)
            dbQuery = navigationProperties(dbQuery);

        if (filter != null)
            dbQuery = dbQuery.Where(filter);

        var item = trackingEnabled
                           ? await dbQuery.Select(selector).FirstOrDefaultAsync()
                           : await dbQuery.AsNoTracking().Select(selector).FirstOrDefaultAsync();

        return item;
    }

    /// <inheritdoc />
    public async Task<int> RemoveAsync(TEntity model)
    {
        this.ModelSet.Remove(model);
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<int> RemoveRangeAsync(IEnumerable<TEntity> models)
    {
        this.ModelSet.RemoveRange(models);
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<int> UpdateAsync(TEntity model)
    {
        this.ModelSet.Update(model);
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }
}
