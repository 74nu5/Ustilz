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
        #region Champs

        /// <summary>The where condition. </summary>
        private readonly IWhereCondition andCondition;

        /// <summary>The condition. </summary>
        private readonly ICondition condition;

        /// <summary>The or condition. </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        private readonly IWhereCondition orCondition;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="WhereCondition"/> class. Initialise une nouvelle instance de la
        ///     classe <see cref="WhereCondition"/>.</summary>
        /// <param name="condition">The condition.</param>
        internal WhereCondition(ICondition condition)
            : this(condition, null, null)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="WhereCondition"/> class. Initialise une nouvelle instance de la
        ///     classe <see cref="WhereCondition"/>.</summary>
        /// <param name="condition">The condition.</param>
        /// <param name="andCondition">The and Condition.</param>
        /// <param name="orCondition">The or Condition.</param>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Reviewed. Suppression is OK here.")]
        internal WhereCondition(ICondition condition, IWhereCondition andCondition, IWhereCondition orCondition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException("condition");
            }

            this.orCondition = orCondition;
            this.condition = condition;
            this.andCondition = andCondition;
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the and condition.</summary>
        /// <value>The and condition.</value>
        public IWhereCondition AndCondition
        {
            get
            {
                return this.andCondition;
            }
        }

        /// <summary>Gets the condition.</summary>
        /// <value>The condition.</value>
        public ICondition Condition
        {
            get
            {
                return this.condition;
            }
        }

        /// <summary>Gets the or condition.</summary>
        /// <value>The or condition.</value>
        public IWhereCondition OrCondition
        {
            get
            {
                return this.orCondition;
            }
        }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            StringBuilder whereConditionBuilder = new StringBuilder(Constantes.Space);

            if (this.condition != null)
            {
                whereConditionBuilder.Append(this.condition);
            }

            if (this.andCondition != null)
            {
                whereConditionBuilder.Append(Constantes.SQL.Keyword.Where.AND);
                whereConditionBuilder.Append(this.andCondition);
            }

            if (this.orCondition != null)
            {
                whereConditionBuilder.Append(Constantes.SQL.Keyword.Where.OR);
                whereConditionBuilder.Append(this.orCondition);
            }

            return whereConditionBuilder.ToString();
        }

        #endregion
    }
}