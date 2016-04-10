namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    #endregion

    /// <summary>The where condition. </summary>
    internal sealed class WhereCondition : IWhereCondition
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="WhereCondition"/> class. Initialise une nouvelle instance de la
        ///     classe <see cref="WhereCondition"/>.</summary>
        /// <param name="condition">The condition.</param>
        /// <param name="andCondition">The and Condition.</param>
        /// <param name="orCondition">The or Condition.</param>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        internal WhereCondition(ICondition condition, IWhereCondition andCondition = null, IWhereCondition orCondition = null)
        {
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            this.OrCondition = orCondition;
            this.Condition = condition;
            this.AndCondition = andCondition;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the and condition.</summary>
        /// <value>The and condition.</value>
        public IWhereCondition AndCondition { get; }

        /// <summary>Gets the condition.</summary>
        /// <value>The condition.</value>
        public ICondition Condition { get; }

        /// <summary>Gets the or condition.</summary>
        /// <value>The or condition.</value>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        public IWhereCondition OrCondition { get; }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            var whereConditionBuilder = new StringBuilder(Constantes.Space);

            whereConditionBuilder.Append(this.Condition);

            if (this.AndCondition != null)
            {
                whereConditionBuilder.Append(Constantes.SQL.Keyword.Where.AND);
                whereConditionBuilder.Append(this.AndCondition);
            }

            if (this.OrCondition != null)
            {
                whereConditionBuilder.Append(Constantes.SQL.Keyword.Where.OR);
                whereConditionBuilder.Append(this.OrCondition);
            }

            return whereConditionBuilder.ToString();
        }

        #endregion
    }
}