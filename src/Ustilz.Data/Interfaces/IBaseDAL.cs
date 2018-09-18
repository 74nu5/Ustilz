namespace Ustilz.Data.Interfaces
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    ///     Interface de définition des méthodes de base des DAL.
    /// </summary>
    /// <typeparam name="TModel">Modèle de la DAL.</typeparam>
    /// <typeparam name="TIdentity">Type de la clé primaire.</typeparam>
    public interface IBaseDAL<TModel, in TIdentity>
        where TModel : class, IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        #region Méthodes publiques

        /// <summary>The create.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> Add(TModel model);

        /// <summary>
        ///     Méthode d'ajout d'une liste d'éléments.
        /// </summary>
        /// <param name="models">La liste d'éléments à ajouter.</param>
        /// <returns>Retourne le nombre de ligne impactées.</returns>
        Task<int> AddRange(IEnumerable<TModel> models);

        /// <summary>The exists.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool Exists(TIdentity id);

        /// <summary>The get all.</summary>
        /// <param name="includes">The includes.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<List<TModel>> GetAll(params Expression<Func<TModel, object>>[] includes);

        /// <summary>The get all.</summary>
        /// <returns>The <see cref="Task" />.</returns>
        Task<List<TModel>> GetAll();

        /// <summary>The get details.</summary>
        /// <param name="id">The id.</param>
        /// <param name="includes">The includes.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<TModel> GetDetails(TIdentity id, params Expression<Func<TModel, object>>[] includes);

        /// <summary>The get details.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<TModel> GetDetails(TIdentity id);

        /// <summary>The remove.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> Remove(TModel model);

        /// <summary>
        ///     Méthode suppression des données de la table.
        /// </summary>
        /// <returns>Retourne le nombre de ligné impactées.</returns>
        Task<int> RemoveAll();

        /// <summary>The update.</summary>
        /// <param name="model">The model.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> Update(TModel model);

        #endregion
    }
}
