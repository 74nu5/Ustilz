namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System.Text;

    using Ustilz.Sql.Enums;

    #endregion

    /// <inheritdoc />
    /// <summary>The join. </summary>
    internal sealed class Join : IJoin
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Join" /> class. Initialise une nouvelle instance de la classe<see cref="Join" />.</summary>
        /// <param name="type">The type.</param>
        /// <param name="joinTable">The join Table.</param>
        /// <param name="otherColumn">The other Column.</param>
        /// <param name="rootColumn">The root Column.</param>
        internal Join(TypeJoin type, ITable joinTable, IColumn otherColumn, IColumn rootColumn)
        {
            this.Type = type;
            this.JoinTable = joinTable;
            this.RootColumn = rootColumn;
            this.OtherColumn = otherColumn;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <inheritdoc />
        /// <summary>Gets the join table. </summary>
        /// <value>The join table.</value>
        public ITable JoinTable { get; }

        /// <inheritdoc />
        /// <summary>Gets the right column. </summary>
        /// <value>The other column.</value>
        public IColumn OtherColumn { get; }

        /// <inheritdoc />
        /// <summary>Gets the left column. </summary>
        /// <value>The root column.</value>
        public IColumn RootColumn { get; }

        /// <inheritdoc />
        /// <summary>Gets or sets the type. </summary>
        /// <value>The type.</value>
        public TypeJoin Type { get; }

        #endregion

        #region Méthodes publiques

        /// <inheritdoc cref="IJoin" />
        /// <summary>Retourne un <see cref="T:System.String" /> qui représente le <see cref="T:System.Object" /> actuel. </summary>
        /// <returns><see cref="T:System.String" /> qui représente le <see cref="T:System.Object" /> actuel.</returns>
        public override string ToString()
        {
            var sql = new StringBuilder(Constantes.Space);
            switch (this.Type)
            {
                case TypeJoin.InnerJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Inner).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.CrossJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Cross).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.LeftJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Left).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.RightJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Right).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.FullJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Full).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.SelfJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Self).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.NaturalJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Natural).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                case TypeJoin.UnionJoin:
                    sql.Append(Constantes.SQL.Keyword.Joinning.Union).Append(Constantes.Space).Append(Constantes.SQL.Keyword.Joinning.Join);
                    break;
                default:
                    sql.Append(string.Empty);
                    break;
            }

            sql.Append(Constantes.Space);

            sql.Append(this.JoinTable);

            sql.Append(Constantes.SQL.Keyword.Joinning.On);

            sql.Append(this.RootColumn.ToStringCondition()).Append(Constantes.Egal).Append(this.OtherColumn.ToStringCondition());

            return sql.ToString();
        }

        #endregion
    }
}
