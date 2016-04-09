namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using Ustilz.Annotations;

    #endregion

    /// <summary>The Table interface.</summary>
    [PublicAPI]
    public interface ITable
    {
        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the alias.</summary>
        /// <value>The alias.</value>
        [CanBeNull]
        string Alias { get; }

        /// <summary>Gets a value indicating whether has alias.</summary>
        /// <value>The has alias.</value>
        bool HasAlias { get; }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        [NotNull]
        string Name { get; }

        #endregion

        #region Méthodes publiques

        /// <summary>The to string.</summary>
        /// <returns>The <see cref="string"/>.</returns>
        string ToString();

        #endregion
    }
}