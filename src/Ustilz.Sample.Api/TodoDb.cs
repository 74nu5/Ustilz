using Microsoft.EntityFrameworkCore;

namespace Ustilz.Sample.Api;

public class TodoDb : DbContext
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="T:Microsoft.EntityFrameworkCore.DbContext" /> class using the specified options.
    ///     The <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" /> method will still be called to allow further
    ///     configuration of the options.
    /// </summary>
    /// <remarks>
    ///     See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see> and
    ///     <see href="https://aka.ms/efcore-docs-dbcontext-options">Using DbContextOptions</see> for more information and examples.
    /// </remarks>
    /// <param name="options">The options for this context.</param>
    public TodoDb(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Todo> Todos => this.Set<Todo>();
}
