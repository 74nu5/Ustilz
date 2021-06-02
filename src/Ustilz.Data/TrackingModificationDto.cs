namespace Ustilz.Data
{
    using System;

    using JetBrains.Annotations;

    using Ustilz.Data.Interfaces;

    /// <summary>
    /// Classe qui représente un DTO avec suivi des dates de modifications.
    /// </summary>
    /// <typeparam name="TIdentity">Type de la clé.</typeparam>
    [PublicAPI]
    public abstract class TrackingModificationDto<TIdentity> : IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        /// <summary>
        ///     Obtient ou définit la date de création.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        ///     Obtient l'identifiant technique.
        /// </summary>
        public abstract TIdentity Id { get; }

        /// <summary>
        ///     Obtient ou définit la date de modification. Cette date peut ne pas être renseignée.
        /// </summary>
        public DateTime? ModificationDate { get; set; }
    }
}
