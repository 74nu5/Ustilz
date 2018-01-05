namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using System.Collections.Generic;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The Joins interface.</summary>
    [PublicAPI]
    public interface IJoins : IList<IJoin>
    {
        #region Méthodes publiques

        /// <summary>The add.</summary>
        /// <param name="item">The item.</param>
        new void Add(IJoin item);

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        string ToString();

        #endregion
    }
}