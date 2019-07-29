namespace Ustilz.Data.Interfaces
{
    #region Usings

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using JetBrains.Annotations;

    #endregion

    /// <summary>
    ///     Interface de définition de d'un Dto.
    /// </summary>
    /// <typeparam name="TIdentity">Type de l'identifiant.</typeparam>
    public interface IDto<out TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        #region Propriétés et indexeurs

        /// <summary>
        ///     Obtient l'identifiant technique.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [UsedImplicitly]
        TIdentity Id { get; }

        #endregion
    }
}
