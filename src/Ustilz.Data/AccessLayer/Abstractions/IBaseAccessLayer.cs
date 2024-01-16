namespace Ustilz.Data.AccessLayer.Abstractions;

using JetBrains.Annotations;

using Ustilz.Data.Entities;

/// <summary>
///     Interface defining base CRUD operation on entity data.
/// </summary>
/// <typeparam name="TEntity">Entity Model that is using this implementation.</typeparam>
/// <typeparam name="TIdentity">The primary key type.</typeparam>
[PublicAPI]
public interface IBaseAccessLayer<TEntity, TIdentity> : IBaseCollectionAccessLayer<TEntity>
        where TEntity : ADataObject<TIdentity>
        where TIdentity : IComparable<TIdentity>
{
    /// <summary>
    ///     Async Method that add new object in Db.
    /// </summary>
    /// <param name="model">Object model to add.</param>
    /// <returns>Returns the Id of newly created object.</returns>
    Task<TIdentity> AddAsync(TEntity model);

    /// <summary>
    ///     Async Method that remove a specific object in Db.
    /// </summary>
    /// <param name="id">The object id of data model to remove.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> RemoveAsync(TIdentity id);

    /// <summary>
    ///     Async method using bulk deletion method to remove data object from db context.
    /// </summary>
    /// <param name="ids">Enumerable of ids of Data object to remove.</param>
    /// <returns>Returns number of state entries written to the database.</returns>
    Task<int> RemoveRangeAsync(IEnumerable<TIdentity> ids);

    /// <summary>
    ///     Check the existence of an object in a collection from based on its id.
    /// </summary>
    /// <param name="id">Id of object to check.</param>
    /// <returns>Returns true if object exists, false otherwise.</returns>
    bool Exists(TIdentity id);
}
