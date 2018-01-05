namespace Ustilz.Sql.RequestType
{
    #region Usings

    using JetBrains.Annotations;

    #endregion

    /// <summary>The Request interface. </summary>
    [PublicAPI]
    public interface IRequest
    {
        #region Méthodes publiques

        /// <summary>The to sql. </summary>
        /// <returns>The <see cref="string"/>. </returns>
        [NotNull]
        string ToSql();

        /// <summary>The to string. </summary>
        /// <returns>The <see cref="string"/>. </returns>
        [NotNull]
        string ToString();

        #endregion
    }
}