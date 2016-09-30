namespace Ustilz.Arguments.TestAttributes
{
    #region Usings

    using System;

    #endregion

    public sealed class BetweenIntAttribute : Attribute, ITestAttribute
    {
        #region Champs

        private readonly int borneInférieur;

        private readonly int borneSupérieur;

        #endregion

        #region Constructeurs et destructeurs

        public BetweenIntAttribute(int borneInférieur, int borneSupérieur)
        {
            this.borneInférieur = borneInférieur;
            this.borneSupérieur = borneSupérieur;
        }

        #endregion

        #region Méthodes publiques

        public bool Test<T>(T value)
        {
            var i = Convert.ToInt32(value);
            return (i > this.borneInférieur) && (i < this.borneSupérieur);
        }

        #endregion
    }
}