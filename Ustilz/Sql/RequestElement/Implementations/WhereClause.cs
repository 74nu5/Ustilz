namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System.Text;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The where clause. </summary>
    [PublicAPI]
    internal sealed class WhereClause : IWhereClause
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="WhereClause"/> class. Initialise une nouvelle instance de la
        ///     classe <see cref="WhereClause"/>.</summary>
        /// <param name="firstCondition">The first Condition.</param>
        internal WhereClause(ICondition firstCondition)
        {
            this.FirstCondition = new WhereCondition(firstCondition);
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the first condition.</summary>
        /// <value>The first condition.</value>
        public IWhereCondition FirstCondition { get; private set; }

        #endregion

        #region Méthodes publiques

        /// <summary>The add condition.</summary>
        /// <param name="condition">The condition.</param>
        public void AddCondition(ICondition condition)
        {
            this.FirstCondition = new WhereCondition(condition);
        }

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            StringBuilder whereBuilder = new StringBuilder(Constantes.Space);
            whereBuilder.Append(Constantes.SQL.Keyword.Where.WHERE);
            whereBuilder.Append(this.FirstCondition);
            return whereBuilder.ToString();
        }

        #endregion
    }
}