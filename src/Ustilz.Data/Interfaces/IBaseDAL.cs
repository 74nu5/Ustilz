namespace Ustilz.Data.Interfaces
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using JetBrains.Annotations;

    #endregion

    /// <summary> Interface de définition des méthodes de base des DAL. </summary>
    /// <typeparam name="TModel"> Modèle de la DAL. </typeparam>
    /// <typeparam name="TIdentity"> Type de la clé primaire. </typeparam>
    [PublicAPI]
    public interface IBaseDAL<TModel, in TIdentity>
        where TModel : class, IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        #region Méthodes publiques

        /// <summary> Méthode d'ajout d'un modèle. </summary>
        /// <param name="model"> Le modèle à ajouter. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne le nombre de modification effectuées en base de données. </returns>
        Task<int> AddModelAsync([NotNull] TModel model, CancellationToken token = default);

        /// <summary> Méthode d'ajout d'une liste d'éléments. </summary>
        /// <param name="models"> La liste d'éléments à ajouter. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne le nombre de ligne impactées. </returns>
        Task<int> AddRangeAsync([NotNull] IEnumerable<TModel> models, CancellationToken token = default);

        /// <summary> Méthide de vérification d'existence d'un élément en base de données. </summary>
        /// <param name="id"> Indentifiant de l'élément à vérifier. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne true si l'élément existe, false sinon. </returns>
        Task<bool> ExistsAsync([NotNull] TIdentity id, CancellationToken token = default);

        /// <summary> The get details. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        Task<TModel> GetDetailsAsync([NotNull] TIdentity id, CancellationToken token = default);

        /// <summary> The get details. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <param name="includes"> The includes. </param>
        /// <returns> The <see cref="Task" />. </returns>
        Task<TModel> GetDetailsWithIncludesAsync([NotNull] TIdentity id, CancellationToken token = default, [NotNull] params Expression<Func<TModel, object>>[] includes);

        /// <summary> Méthode suppression des données de la table. </summary>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> Retourne le nombre de ligné impactées. </returns>
        Task<int> RemoveAllAsync(CancellationToken token = default);

        /// <summary> The remove. </summary>
        /// <param name="model"> The model. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        Task<int> RemoveAsync([NotNull] TModel model, CancellationToken token = default);

        /// <summary> The update. </summary>
        /// <param name="model"> The model. </param>
        /// <param name="token"> Token d'annulation de la tache. </param>
        /// <returns> The <see cref="Task" />. </returns>
        Task<int> UpdateAsync([NotNull] TModel model, CancellationToken token = default);

        #endregion
    }
}
