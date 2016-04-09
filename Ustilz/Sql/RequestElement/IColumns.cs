namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using System.Collections.Generic;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The Columns interface.</summary>
    [PublicAPI]
    public interface IColumns : IList<IColumn>
    {
        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the owner table. </summary>
        /// <value>The owner table.</value>
        [NotNull]
        ITable OwnerTable { get; }

        #endregion

        #region Méthodes publiques

        /// <summary>The add.</summary>
        /// <param name="nomColumn">The nom column.</param>
        [ContractAnnotation("nomColumn:null => halt")]
        void Add([NotNull] string nomColumn);

        /// <summary>The add.</summary>
        /// <param name="nomColumn">The nom column.</param>
        /// <param name="alias">The alias.</param>
        void Add([NotNull] string nomColumn, [CanBeNull] string alias);

        /// <summary>The to string array. </summary>
        /// <returns>The <see cref="string" />. </returns>
        string[] ToStringArray();

        #endregion
    }
}