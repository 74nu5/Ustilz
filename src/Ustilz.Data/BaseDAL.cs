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

    /// <summary>The totem dao.</summary>
    /// <typeparam name="TContext">Type du contexte.</typeparam>
    /// <typeparam name="TModel">Type du model.</typeparam>
    /// <typeparam name="TIdentity">Type de la clé primaire du model.</typeparam>
    [PublicAPI]
    public abstract class BaseDAL<TContext, TModel, TIdentity>
        : IBaseDAL<TModel, TIdentity>
        where TModel : class, IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
        where TContext : DbContext
    {
        #region Champs

        private readonly TContext context;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initialise une nouvelle instance de la classe <see cref="BaseDAL{Tcontext, TModel, TIdentity}" />.</summary>
        /// <param name="context">The context.</param>
        protected BaseDAL(TContext context)
        {
            this.context = context;
            this.Queryable = this.context.Set<TModel>().AsQueryable();
        }

        #endregion

        #region Propriétés et indexeurs

        /// <inheritdoc />
        public IQueryable<TModel> Queryable { get; }

        #endregion

        #region Méthodes publiques

        /// <inheritdoc />
        public int Add(TModel model)
        {
            this.context.Set<TModel>().Add(model);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> AddAsync(TModel model, CancellationToken stoppingToken = default)
        {
            await this.context.Set<TModel>().AddAsync(model, stoppingToken);
            return await this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        public int AddRange(IEnumerable<TModel> models)
        {
            this.context.Set<TModel>().AddRange(models);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> AddRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            await this.context.Set<TModel>().AddRangeAsync(models, stoppingToken);
            return await this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        public bool Exists(TIdentity id) => this.context.Set<TModel>().Any(e => e.Id.CompareTo(id) == 0);

        /// <inheritdoc />
        public async Task<bool> ExistsAsync(TIdentity id, CancellationToken stoppingToken = default)
            => await this.context.Set<TModel>().AnyAsync(e => e.Id.CompareTo(id) == 0, stoppingToken).ConfigureAwait(false);

        /// <inheritdoc />
        public List<TModel> GetAll(params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null ? set.ToList() : includeSet.ToList();
        }

        /// <inheritdoc />
        public List<TModel> GetAll(int skip, int take)
            => this.SkipAndTake(skip, take).ToList();

        /// <inheritdoc />
        public async Task<List<TModel>> GetAllAsync(CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null ? await set.ToListAsync(stoppingToken).ConfigureAwait(false) : await includeSet.ToListAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<List<TModel>> GetAllAsync(int skip, int take, CancellationToken stoppingToken = default)
            => await this.SkipAndTake(skip, take).ToListAsync(stoppingToken);

        /// <inheritdoc />
        public TModel GetDetails(TIdentity id, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null
                       ? set.SingleOrDefault(model => model.Id.CompareTo(id) == 0)
                       : includeSet.SingleOrDefault(model => model.Id.CompareTo(id) == 0);
        }

        /// <inheritdoc />
        public TModel GetDetails(TIdentity id) => this.context.Set<TModel>().SingleOrDefault(model => model.Id.CompareTo(id) == 0);

        /// <inheritdoc />
        public async Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = GetIncludeSet(includes, set);
            return includeSet == null
                       ? await set.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken)
                       : await includeSet.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken);
        }

        /// <inheritdoc />
        public async Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default)
            => await this.context.Set<TModel>().SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, stoppingToken);

        /// <inheritdoc />
        public int Remove(TModel model)
        {
            this.context.Set<TModel>().Remove(model);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public int RemoveAll()
        {
            this.context.Set<TModel>().RemoveRange(this.Queryable.ToList());
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> RemoveAllAsync(CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().RemoveRange(await this.Queryable.ToListAsync(stoppingToken).ConfigureAwait(false));
            return await this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        public async Task<int> RemoveAsync(TModel model, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().Remove(model);
            return await this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        public int RemoveRange(IEnumerable<TModel> models)
        {
            this.context.Set<TModel>().RemoveRange(models);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> RemoveRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().RemoveRange(models);
            return await this.context.SaveChangesAsync(stoppingToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public int Update(TModel model)
        {
            this.context.Set<TModel>().Update(model);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> UpdateAsync(TModel model, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().Update(model);
            return await this.context.SaveChangesAsync(stoppingToken);
        }

        /// <inheritdoc />
        public int UpdateRange(IEnumerable<TModel> models)
        {
            this.context.Set<TModel>().UpdateRange(models);
            return this.context.SaveChanges();
        }

        /// <inheritdoc />
        public async Task<int> UpdateRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default)
        {
            this.context.Set<TModel>().UpdateRange(models);
            return await this.context.SaveChangesAsync(stoppingToken).ConfigureAwait(false);
        }

        #endregion

        #region Méthodes privées

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

        #endregion
    }
}
