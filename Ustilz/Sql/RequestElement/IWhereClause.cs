﻿namespace Ustilz.Sql.RequestElement
{
    #region Usings

    using JetBrains.Annotations;

    #endregion

    /// <summary>The WhereClause interface.</summary>
    [PublicAPI]
    public interface IWhereClause
    {
        #region Propriétés et indexeurs

        /// <summary>Gets the first condition.</summary>
        /// <value>The first condition.</value>
        [NotNull]
        IWhereCondition FirstCondition { get; }

        #endregion
    }
}