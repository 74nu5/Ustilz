namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using JetBrains.Annotations;

    #endregion

    /// <summary>The Column interface.</summary>
    [PublicAPI]
    public interface IColumn
    {
        #region Propriétés et indexeurs

        /// <summary>Gets the alias. </summary>
        /// <value>The alias.</value>
        [CanBeNull]
        string Alias { get; }

        /// <summary>Gets a value indicating whether has alias. </summary>
        /// <value>The has alias.</value>
        bool HasAlias { get; }

        /// <summary>Gets the name. </summary>
        /// <value>The name.</value>
        [NotNull]
        string Name { get; }

        /// <summary>Gets the owner table. </summary>
        /// <value>The owner table.</value>
        [NotNull]
        ITable OwnerTable { get; }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        string ToString();

        /// <summary>The to string condition. </summary>
        /// <returns>The <see cref="string"/>. </returns>
        string ToStringCondition();

        #endregion
    }
}