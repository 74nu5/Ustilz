namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using Ustilz.Annotations;

    #endregion

    /// <summary>The WhereClause interface.</summary>
    [PublicAPI]
    public interface IWhereClause
    {
        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the first condition.</summary>
        /// <value>The first condition.</value>
        [NotNull]
        IWhereCondition FirstCondition { get; }

        #endregion
    }
}