namespace Ustilz.Sql
{
    #region Usings

    using JetBrains.Annotations;
    using Ustilz.Sql.RequestType;
    using Ustilz.Sql.RequestType.Implementations;

    #endregion

    /// <summary>The factory request. </summary>
    [PublicAPI]
    public static class FactoryRequest
    {
        #region Méthodes publiques

        /// <summary>The get select request.</summary>
        /// <param name="nomTable">The nom table.</param>
        /// <param name="alias">The alias.</param>
        /// <returns>The <see cref="ISelectRequest"/>.</returns>
        [NotNull]
        public static ISelectRequest GetSelectRequest([NotNull] string nomTable, [NotNull] string alias)
        {
            return new SelectRequest(nomTable, alias);
        }

        #endregion
    }
}