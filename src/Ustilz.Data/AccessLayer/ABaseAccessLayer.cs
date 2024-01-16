namespace Ustilz.Data.AccessLayer;

using JetBrains.Annotations;

using Ustilz.Data.AccessLayer.Abstractions;
using Ustilz.Data.Entities;

/// <summary>
///     Provides a base implementation for access layer.
/// </summary>
/// <typeparam name="TContext">Type context type.</typeparam>
/// <typeparam name="TEntity">Type entity type.</typeparam>
/// <typeparam name="TIdentity">The primary key type.</typeparam>
[PublicAPI]
public abstract class ABaseAccessLayer<TContext, TEntity, TIdentity> : ABaseCollectionAccessLayer<TContext, TEntity>, IBaseAccessLayer<TEntity, TIdentity>
        where TContext : ADbContext
        where TEntity : ADataObject<TIdentity>
        where TIdentity : IComparable<TIdentity>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ABaseAccessLayer{TContext, TEntity, TIdentity}" /> class.
    /// </summary>
    /// <param name="context">The DB context.</param>
    protected ABaseAccessLayer(TContext context)
            : base(context)
    {
    }

    /// <inheritdoc />
    public async Task<TIdentity> AddAsync(TEntity model)
    {
        var result = this.ModelSet.Add(model);
        await this.Context.SaveChangesAsync().ConfigureAwait(false);

        return result.Entity.Id;
    }

    /// <inheritdoc />
    public bool Exists(TIdentity id)
        => this.GetCollection(filter: o => o.Id.CompareTo(id) == 0).Any();

    /// <inheritdoc />
    public async Task<int> RemoveAsync(TIdentity id)
    {
        var model = this.ModelSet.FirstOrDefault(model => model.Id.CompareTo(id) == 0);
        if (model == null)
            return -1;

        this.ModelSet.Remove(model);
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<int> RemoveRangeAsync(IEnumerable<TIdentity> ids)
    {
        this.ModelSet.RemoveRange(this.ModelSet.Where(model => ids.Contains(model.Id)));
        return await this.Context.SaveChangesAsync().ConfigureAwait(false);
    }
}
