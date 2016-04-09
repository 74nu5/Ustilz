namespace Ustilz.Sql
{
    #region Usings

    using Ustilz.Annotations;
    using Ustilz.Sql.RequestElement;
    using Ustilz.Sql.RequestElement.Implementations;

    #endregion

    /// <summary>The factory request element.</summary>
    [PublicAPI]
    public static class FactoryRequestElement
    {
        #region Méthodes statiques

        /// <summary>The create table.</summary>
        /// <param name="nom">The nom.</param>
        /// <param name="alias">The alias.</param>
        /// <returns>The <see cref="ITable"/>.</returns>
        [NotNull]
        public static ITable CreateTable(string nom, string alias)
        {
            return new Table(nom, alias);
        }

        /// <summary>The create column.</summary>
        /// <param name="table">The nom.</param>
        /// <param name="alias">The alias.</param>
        /// <returns>The <see cref="IColumn"/>.</returns>
        [NotNull]
        public static IColumn CreateColumn(ITable table, string alias)
        {
            return new Column(table, alias);
        }

        #endregion
    }
}