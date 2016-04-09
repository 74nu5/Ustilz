namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>The joins. </summary>
    internal sealed class Joins : List<IJoin>, IJoins
    {
        #region M�thodes publiques

        /// <summary>Retourne un <see cref="T:System.String" /> qui repr�sente le <see cref="T:System.Object" /> actuel. </summary>
        /// <returns><see cref="T:System.String" /> qui repr�sente le <see cref="T:System.Object" /> actuel.</returns>
        public override string ToString()
        {
            var sql = new StringBuilder();
            foreach (var join in this)
            {
                sql.Append(join);
            }

            return sql.ToString();
        }

        /// <summary>The add.</summary>
        /// <param name="item">The item.</param>
        public new void Add(IJoin item)
        {
            base.Add(item);
        }

        #endregion
    }
}