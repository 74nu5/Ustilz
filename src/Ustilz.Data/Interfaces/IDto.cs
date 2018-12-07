namespace Ustilz.Data.Interfaces
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    ///     Interface de définition de d'un Dto.
    /// </summary>
    /// <typeparam name="TIdentity">Type de l'identifiant.</typeparam>
    public interface IDto<TIdentity>
        where TIdentity : IComparable<TIdentity>
    {
        #region Propriétés et indexeurs

        /// <summary>
        ///     Obtient ou définit l'identifiant technique.
        /// </summary>
        TIdentity Id { get; }

        #endregion
    }
}
