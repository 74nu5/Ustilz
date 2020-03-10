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
        /// <summary>The tolerance two decimal.</summary>
        private const double ToleranceTwoDecimal = 0.01;

        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur décimale passée en paramètre.</summary>
        /// <param name="time">Valeur décimal à convertir.</param>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimale passée en paramètre.</returns>
        public static TimeSpan Hours(this double time)
        {
            var h = Math.Round(time);
            var min = (time - h) * 60;

            return TimeSpan.FromMinutes((60 * h) + min);
        }

        /// <summary>Compare deux doubles pour savoir si ils sont égaux à la deuxième décimales près.</summary>
        /// <param name="valeur1">The valeur1.</param>
        /// <param name="valeur2">The valeur2.</param>
        /// <returns><c>true</c> if [is nearly equal by two decimals] [the specified valeur2]; otherwise, <c>false</c>.</returns>
        public static bool IsNearlyEqualByTwoDecimals(this double valeur1, double valeur2)
            => Math.Abs(valeur1 - valeur2) < ToleranceTwoDecimal;
    }
}
