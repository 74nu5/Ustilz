namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System.Text;

    #endregion

    /// <summary>The condition. </summary>
    internal sealed class Condition : ICondition
    {
        #region Champs

        /// <summary>The left member. </summary>
        private readonly IColumn leftMember;

        /// <summary>The right member. </summary>
        private readonly IColumn rightMember;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Condition"/> class. Initialise une nouvelle instance de la
        ///     classe <see cref="Condition"/>.</summary>
        /// <param name="rightMember">The right member.</param>
        /// <param name="leftMember">The left member.</param>
        public Condition(IColumn rightMember, IColumn leftMember)
        {
            this.rightMember = rightMember;
            this.leftMember = leftMember;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.leftMember.ToStringCondition());
            sb.Append(Constantes.Egal);
            sb.Append(this.rightMember.ToStringCondition());
            return sb.ToString();
        }

        #endregion
    }
}