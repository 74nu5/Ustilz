namespace Ustilz.Sql.Enums
{
    #region Usings

    using Ustilz.Annotations;

    #endregion

    /// <summary>The type join. </summary>
    [PublicAPI]
    public enum TypeJoin
    {
        /// <summary>The inner join. </summary>
        InnerJoin,

        /// <summary>The cross join. </summary>
        CrossJoin,

        /// <summary>The left join. </summary>
        LeftJoin,

        /// <summary>The right join. </summary>
        RightJoin,

        /// <summary>The full join. </summary>
        FullJoin,

        /// <summary>The self join. </summary>
        SelfJoin,

        /// <summary>The natural join. </summary>
        NaturalJoin,

        /// <summary>The union join. </summary>
        UnionJoin
    }
}