namespace Ustilz.Data;

using Microsoft.EntityFrameworkCore;

using Ustilz.Data.Interfaces;

/// <summary>
///     Represents the application Database.
/// </summary>
public abstract class ADbContext : DbContext
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ADbContext" /> class.
    /// </summary>
    /// <param name="options">The db context options.</param>
    protected ADbContext(DbContextOptions options)
        : base(options)
    {
    }

    /// <summary>
    ///     Update <seealso cref="ITraceableDataObject.CreationDate" /> and <seealso cref="ITraceableDataObject.LastModifiedDate" /> before apply changes in databse.
    /// </summary>
    /// <returns>The number of state entrie written to the database.</returns>
    public override int SaveChanges()
    {
        this.UpdateDateChanges();
        return base.SaveChanges();
    }

    /// <summary>
    ///     Async method to update <seealso cref="ITraceableDataObject.CreationDate" /> and <seealso cref="ITraceableDataObject.LastModifiedDate" /> before apply changes in databse.
    /// </summary>
    /// <param name="cancellationToken">The token for async task cancellation.</param>
    /// <returns>The number of state entrie written to the database.</returns>
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        this.UpdateDateChanges();
        return base.SaveChangesAsync(cancellationToken);
    }

    /// <summary>
    ///     For each entity to be saved in database, this method fills :
    ///     <list type="bullet">
    ///         <item>
    ///             <seealso cref="ITraceableDataObject.CreationDate" /> if entity state is <seealso cref="EntityState.Added" />
    ///         </item>
    ///         <item>
    ///             <seealso cref="ITraceableDataObject.LastModifiedDate" /> if entity state is <seealso cref="EntityState.Modified" />
    ///         </item>
    ///     </list>
    /// </summary>
    private void UpdateDateChanges()
    {
        var changes = this.ChangeTracker.Entries().Where(entity => entity.State != EntityState.Unchanged);

        foreach (var item in changes)
        {
            switch (item)
            {
                case { State: EntityState.Added, Entity: ITraceableDataObject dataObjAdded }:
                    dataObjAdded.CreationDate = DateTime.UtcNow;
                    break;
                case { State: EntityState.Modified, Entity: ITraceableDataObject dataObjAdded }:
                    dataObjAdded.LastModifiedDate = DateTime.UtcNow;
                    break;
            }
        }
    }
}
