namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using Ustilz.Annotations;

    #endregion

    /// <summary>The WhereCondition interface. </summary>
    [PublicAPI]
    public interface IWhereCondition
    {
        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the and condition. </summary>
        /// <value>The and condition.</value>
        [CanBeNull]
        IWhereCondition AndCondition { get; }

        /// <summary>Gets the condition. </summary>
        /// <value>The condition.</value>
        [NotNull]
        ICondition Condition { get; }

        /// <summary>Gets the or condition. </summary>
        /// <value>The or condition.</value>
        [CanBeNull]
        IWhereCondition OrCondition { get; }

        #endregion
    }
}