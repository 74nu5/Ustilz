namespace Ustilz.Data
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using JetBrains.Annotations;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query;

    using Ustilz.Data.Interfaces;

    #endregion

    /// <summary> The totem dao. </summary>
    /// <typeparam name="TContext"> Type du contexte. </typeparam>
    /// <typeparam name="TModel"> Type du model. </typeparam>
    /// <typeparam name="TIdentity"> Type de la clé primaire du model. </typeparam>
    [PublicAPI]
    public abstract class BaseDAL<TContext, TModel, TIdentity>
        : IBaseDAL<TModel, TIdentity>
        where TModel : class, IDto<TIdentity>
        where TContext : DbContext
        where TIdentity : IComparable<TIdentity>
    {
        private readonly TContext context;

        /// <summary>Initialise une nouvelle instance de la classe <see cref="BaseDAL{Tcontext, TModel, TIdentity}" />.</summary>
        /// <param name="context">The context.</param>
        /// <exception cref="ArgumentNullException"><paramref name="context" /> is null.</exception>
        protected BaseDAL([NotNull] TContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.Queryable = this.context.Set<TModel>().AsQueryable();
        }

        /// <inheritdoc />
        public IQueryable<TModel> Queryable { get; }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public async Task<int> AddAsync(TModel model, CancellationToken stoppingToken = default)
        {
            await this.context.Set<TModel>().AddAsync(model, stoppingToken).ConfigureAwait(false);
            return await this.context.SaveChangesAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public async Task<int> AddRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            await this.context.Set<TModel>().AddRangeAsync(models, stoppingToken).ConfigureAwait(false);
            return await this.context.SaveChangesAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public Task<bool> ExistsAsync(TIdentity id, CancellationToken stoppingToken = default)
            => this.context.Set<TModel>().AnyAsync(e => e.Id.CompareTo(id) == 0, stoppingToken);

        /// <inheritdoc />
        public async Task<List<TModel>> GetAllAsync(CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null ? await set.ToListAsync(stoppingToken).ConfigureAwait(false) : await includeSet.ToListAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public Task<List<TModel>> GetAllAsync(int skip, int take, CancellationToken stoppingToken = default)
            => this.SkipAndTake(skip, take).ToListAsync(stoppingToken);

        /// <inheritdoc />
        public async Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null
                       ? await set.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken).ConfigureAwait(false)
                       : await includeSet.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default)
            => this.context.Set<TModel>().SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken);

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public async Task<int> RemoveAllAsync(CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().RemoveRange(await this.Queryable.ToListAsync(stoppingToken).ConfigureAwait(false));
            return await this.context.SaveChangesAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public Task<int> RemoveAsync(TModel model, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().Remove(model);
            return this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public Task<int> RemoveRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().RemoveRange(models);
            return this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public Task<int> UpdateAsync(TModel model, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().Update(model);
            return this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        /// <exception cref="DbUpdateException">An error is encountered while saving to the database.</exception>
        /// <exception cref="DbUpdateConcurrencyException">
        ///     A concurrency violation is encountered while saving to the database. A concurrency violation occurs when an unexpected number of
        ///     rows are affected during save. This is usually because the data in the database has been modified since it was loaded into memory.
        /// </exception>
        public Task<int> UpdateRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().UpdateRange(models);
            return this.context.SaveChangesAsync(stoppingToken);
        }

        /// <summary> The get all with pagination. </summary>
        /// <param name="skip"> The skip. </param>
        /// <param name="take"> The take. </param>
        /// <returns> The <see cref="Task" />. </returns>
        protected IQueryable<TModel> GetQueryablePaged(int skip, int take)
        {
            var queryable = this.Queryable.Skip(skip);

            if (take > 0)
            {
                queryable = queryable.Take(take);
            }

            return queryable;
        }

        private static IIncludableQueryable<TModel, object> GetIncludeSet(Expression<Func<TModel, object>>[] includes, DbSet<TModel> set)
            => includes.Aggregate<Expression<Func<TModel, object>>, IIncludableQueryable<TModel, object>>(
#pragma warning disable CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non Nullable.
                null,
#pragma warning restore CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non Nullable.
                (current, include) =>
                    current == null
                        ? set.Include(include)
                        : current.Include(include));

        private IQueryable<TModel> SkipAndTake(int skip, int take)
        {
            var queryable = this.context.Set<TModel>().Skip(skip);

            if (take > 0)
            {
                queryable = queryable.Take(take);
            }

            return queryable;
        }
    }
}
