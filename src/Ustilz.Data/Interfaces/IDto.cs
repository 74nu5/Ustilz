namespace Ustilz.Data.Interfaces
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using JetBrains.Annotations;

    /// <summary>
    ///     Interface de définition de d'un Dto.
    /// </summary>
    /// <typeparam name="TIdentity">Type de l'identifiant.</typeparam>
    [PublicAPI]
    public interface IDto<out TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        /// <summary>
        ///     Obtient l'identifiant technique.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        TIdentity Id { get; }
    }
}
