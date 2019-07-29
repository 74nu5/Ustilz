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
        #region Champs

        private readonly TContext context;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary> Initialise une nouvelle instance de la classe <see cref="BaseDAL{TContext, TModel, TIdentity}" />. </summary>
        /// <param name="context"> The context. </param>
        protected BaseDAL(TContext context)
        {
            this.context = context;
            this.Queryable = this.context.Set<TModel>();
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary> Obtient le contexte de la base de données. </summary>
        protected IQueryable<TModel> Queryable { get; }

        #endregion

        #region Méthodes publiques

        /// <summary> The create. </summary>
        /// <param name="model"> The model. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        public async Task<int> AddModelAsync(TModel model, CancellationToken token)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            await this.context.Set<TModel>().AddAsync(model, token).ConfigureAwait(false);
            return await this.context.SaveChangesAsync(token).ConfigureAwait(false);
        }

        /// <summary> Méthode d'ajout d'une liste d'éléments. </summary>
        /// <param name="models"> La liste d'éléments à ajouter. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne le nombre de ligne impactées. </returns>
        public async Task<int> AddRangeAsync(IEnumerable<TModel> models, CancellationToken token)
        {
            if (models == null)
            {
                throw new ArgumentNullException(nameof(models));
            }

            await this.context.Set<TModel>().AddRangeAsync(models, token).ConfigureAwait(false);
            return await this.context.SaveChangesAsync(token).ConfigureAwait(false);
        }

        /// <summary> The exists. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="bool" />. </returns>
        public Task<bool> ExistsAsync(TIdentity id, CancellationToken token)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return this.context.Set<TModel>().AnyAsync(e => e.Id.CompareTo(id) == 0, token);
        }

        /// <summary> The get details. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        public Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken token)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return this.context.Set<TModel>().SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, token);
        }

        /// <summary> The get details. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <param name="includes"> The includes. </param>
        /// <returns> The <see cref="Task" />. </returns>
        public async Task<TModel> GetDetailsWithIncludesAsync(TIdentity id, CancellationToken token, params Expression<Func<TModel, object>>[] includes)
        {
            var set = this.context.Set<TModel>();
            var includeSet = includes.Aggregate<Expression<Func<TModel, object>>, IIncludableQueryable<TModel, object>>(
                null,
                (current, include)
                    => current == null
                           ? set.Include(include)
                           : current.Include(include));
            return includeSet == null
                       ? await set.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, token).ConfigureAwait(false)
                       : await includeSet.SingleOrDefaultAsync(model => model.Id.CompareTo(id) == 0, token).ConfigureAwait(false);
        }

        /// <summary> Méthode suppression des données de la table. </summary>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne le nombre de ligné impactées. </returns>
        public Task<int> RemoveAllAsync(CancellationToken token)
        {
            this.context.Set<TModel>().RemoveRange(this.GetQueryableWithIncludes());
            return this.context.SaveChangesAsync(token);
        }

        /// <summary> The remove. </summary>
        /// <param name="model"> The model. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        public Task<int> RemoveAsync(TModel model, CancellationToken token)
        {
            this.context.Set<TModel>().Remove(model);
            return this.context.SaveChangesAsync(token);
        }

        /// <summary> The update. </summary>
        /// <param name="model"> The model. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        public Task<int> UpdateAsync(TModel model, CancellationToken token)
        {
            this.context.Set<TModel>().Update(model);
            return this.context.SaveChangesAsync(token);
        }

        #endregion

        /// <summary> The get all. </summary>
        /// <param name="includes"> The includes. </param>
        /// <returns> The <see cref="Task" />. </returns>
        protected IQueryable<TModel> GetQueryableWithIncludes(params Expression<Func<TModel, object>>[] includes)
        {
            if (includes == null)
            {
                throw new ArgumentNullException(nameof(includes));
            }

            var includeSet = includes.Aggregate<Expression<Func<TModel, object>>, IIncludableQueryable<TModel, object>>(
                null,
                (current, include) =>
                    current == null
                        ? this.Queryable.Include(include)
                        : current.Include(include));
            return includeSet?.AsQueryable() ?? this.Queryable?.AsQueryable();
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
    }
}
