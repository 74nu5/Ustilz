namespace Ustilz.Data.Interfaces
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Interface de définition des méthodes de base des DAL.</summary>
    /// <typeparam name="TModel">Modèle de la DAL.</typeparam>
    /// <typeparam name="TIdentity">Type de la clé primaire.</typeparam>
    [PublicAPI]
    public interface IBaseDAL<TModel, in TIdentity>
        where TModel : class, IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        /// <summary>Obtient le contexte de la base de données.</summary>
        IQueryable<TModel> Queryable { get; }

        /// <summary>The create.</summary>
        /// <param name="model">The model.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> AddAsync(TModel model, CancellationToken stoppingToken = default);

        /// <summary>Méthode d'ajout d'une liste d'éléments.</summary>
        /// <param name="models">La liste d'éléments à ajouter.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>Retourne le nombre de ligne impactées.</returns>
        Task<int> AddRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default);

        /// <summary>The exists.</summary>
        /// <param name="id">The id.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="bool" />.</returns>
        Task<bool> ExistsAsync(TIdentity id, CancellationToken stoppingToken = default);

        /// <summary>The get all.</summary>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <param name="includes">The includes.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<List<TModel>> GetAllAsync(CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes);

        /// <summary>The get all with pagination.</summary>
        /// <param name="skip">The skip.</param>
        /// <param name="take">The take.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<List<TModel>> GetAllAsync(int skip, int take, CancellationToken stoppingToken = default);

        /// <summary>The get details.</summary>
        /// <param name="id">The id.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <param name="includes">The includes.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default, params Expression<Func<TModel, object>>[] includes);

        /// <summary>The get details.</summary>
        /// <param name="id">The id.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<TModel> GetDetailsAsync(TIdentity id, CancellationToken stoppingToken = default);

        /// <summary>Méthode suppression des données de la table.</summary>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>Retourne le nombre de ligné impactées.</returns>
        Task<int> RemoveAllAsync(CancellationToken stoppingToken = default);

        /// <summary>The remove.</summary>
        /// <param name="model">The model.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> RemoveAsync(TModel model, CancellationToken stoppingToken = default);

        /// <summary>Méthode suppression des données de la table.</summary>
        /// <param name="models">Liste des modèles à supprimer.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>Retourne le nombre de ligné impactées.</returns>
        Task<int> RemoveRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default);

        /// <summary>The update.</summary>
        /// <param name="model">The model.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> UpdateAsync(TModel model, CancellationToken stoppingToken = default);

        /// <summary>The update range.</summary>
        /// <param name="models">La liste des modèles à mettre à jour.</param>
        /// <param name="stoppingToken">Token d'arret de la tache.</param>
        /// <returns>The <see cref="Task" />.</returns>
        Task<int> UpdateRangeAsync(IEnumerable<TModel> models, CancellationToken stoppingToken = default);
    }
}
