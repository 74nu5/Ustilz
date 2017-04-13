namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using JetBrains.Annotations;

    #endregion

    /// <summary>The Condition interface.</summary>
    [PublicAPI]
    public interface ICondition
    {
        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        string ToString();

        #endregion
    }
}