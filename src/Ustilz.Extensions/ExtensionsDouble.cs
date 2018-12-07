namespace Ustilz.Extensions
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Extensions pour le type double.</summary>
    [PublicAPI]
    public static class ExtensionsDouble
    {
        #region Champs et constantes statiques

        /// <summary>The tolerance two decimal.</summary>
        private const double ToleranceTwoDecimal = 0.01;

        #endregion

        #region Méthodes publiques

        /// <summary>Compare deux doubles pour savoir si ils sont égaux à la deuxième décimales près.</summary>
        /// <param name="valeur1">The valeur1.</param>
        /// <param name="valeur2">The valeur2.</param>
        /// <returns><c>true</c> if [is nearly equal by two decimals] [the specified valeur2]; otherwise, <c>false</c>.</returns>
        public static bool IsNearlyEqualByTwoDecimals(this double valeur1, double valeur2)
            => Math.Abs(valeur1 - valeur2) < ToleranceTwoDecimal;

        #endregion
    }
}
