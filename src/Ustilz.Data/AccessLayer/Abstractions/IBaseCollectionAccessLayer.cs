namespace Ustilz.Data.AccessLayer.Abstractions;

using System.Linq.Expressions;

using JetBrains.Annotations;

using Microsoft.EntityFrameworkCore.Query;

/// <summary>
///     Interface defining base CRUD operation on entity data.
/// </summary>
/// <typeparam name="TEntity">Entity Model that is using this implementation.</typeparam>
[PublicAPI]
public interface IBaseCollectionAccessLayer<TEntity>
{
    /// <summary>
    ///     Async Method that add a range of new object in Db.
    /// </summary>
    /// <param name="models">Enumerable of objects model to add.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> AddRangeAsync(IEnumerable<TEntity> models);

    /// <summary>
    ///     Async method that update a specific data object.
    /// </summary>
    /// <param name="model">The object data model to update.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> UpdateAsync(TEntity model);

    /// <summary>
    ///     Async Method that remove a specific object in Db.
    /// </summary>
    /// <param name="model">The object data model to remove.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> RemoveAsync(TEntity model);

    /// <summary>
    ///     Async method using bulk deletion method to remove data object from db context.
    /// </summary>
    /// <param name="models">Enumerable of Data object to remove.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> RemoveRangeAsync(IEnumerable<TEntity> models);

    /// <summary>
    ///     Method that retrieve a collection of data according to the filter.
    /// </summary>
    /// <remarks>
    ///     Tracking on data returned is disabled by default.
    /// </remarks>
    /// <param name="filter">Expression to filter data to return.</param>
    /// <param name="trackingEnabled">true if tracking is needed on data returned, false otherwise.</param>
    /// <param name="navigationProperties">Navigation properties to include for data to returned.</param>
    /// <returns>Returns Enumerable of <typeparamref name="TEntity" />.</returns>
    IQueryable<TEntity> GetCollection(
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null);

    /// <summary>
    ///     Method that retrieve a collection of data according to the filter.
    /// </summary>
    /// <remarks>
    ///     Tracking on data returned is disabled by default.
    /// </remarks>
    /// <typeparam name="TResult">Type result type.</typeparam>
    /// <param name="selector">The selector to apply.</param>
    /// <param name="filter">Expression to filter data to return.</param>
    /// <param name="trackingEnabled">true if tracking is needed on data returned, false otherwise.</param>
    /// <param name="navigationProperties">Navigation properties to include for data to returned.</param>
    /// <returns>Returns Enumerable of <typeparamref name="TResult" />.</returns>
    IQueryable<TResult> GetCollection<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null);

    /// <summary>
    ///     Async Method that retrieve first data object matching the given filter.
    /// </summary>
    /// <remarks>
    ///     Tracking on data returned is disabled by default.
    /// </remarks>
    /// <param name="filter">filter to apply.</param>
    /// <param name="trackingEnabled">true if tracking is needed on data returned, false otherwise.</param>
    /// <param name="navigationProperties">Navigation properties to include for data to returned.</param>
    /// <returns>Returns <typeparamref name="TEntity" />.</returns>
    Task<TEntity?> GetSingleAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null);

    /// <summary>
    ///     Async Method that retrieve first data object matching the given filter.
    /// </summary>
    /// <remarks>
    ///     Tracking on data returned is disabled by default.
    /// </remarks>
    /// <typeparam name="TResult">Type result type.</typeparam>
    /// <param name="selector">The selector to apply.</param>
    /// <param name="filter">filter to apply.</param>
    /// <param name="trackingEnabled">true if tracking is needed on data returned, false otherwise.</param>
    /// <param name="navigationProperties">Navigation properties to include for data to returned.</param>
    /// <returns>Returns <typeparamref name="TEntity" />.</returns>
    Task<TResult?> GetSingleAsync<TResult>(
        Expression<Func<TEntity, TResult>> selector,
        Expression<Func<TEntity, bool>>? filter = null,
        bool trackingEnabled = false,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? navigationProperties = null);
}
