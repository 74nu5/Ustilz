namespace Ustilz.Extensions.Misc;

using System;

using JetBrains.Annotations;

/// <summary>Extensions pour le type double.</summary>
[PublicAPI]
public static class DoubleExtensions
{
    /// <summary>The tolerance two decimal.</summary>
    private const double ToleranceTwoDecimal = 0.01;

    extension(double time)
    {
        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur décimale passée en paramètre.</summary>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimale passée en paramètre.</returns>
        public TimeSpan Hours()
        {
            var h = Math.Round(time);
            var min = (time - h) * 60;

            return TimeSpan.FromMinutes(60 * h + min);
        }
    }

    extension(double valeur1)
    {
        /// <summary>Compare deux doubles pour savoir si ils sont égaux à la deuxième décimales près.</summary>
        /// <returns><c>true</c> if [is nearly equal by two decimals] [the specified valeur2]; otherwise, <c>false</c>.</returns>
        public bool IsNearlyEqualByTwoDecimals(double valeur2)
            => Math.Abs(valeur1 - valeur2) < ToleranceTwoDecimal;
    }

    extension(double value)
    {
        /// <summary>
        /// Get a certain percentage of the specified number.
        /// </summary>
        /// <returns>The actual specified percentage of the specified number.</returns>
        public double GetPercentage(int percentage)
            => value * percentage / 100;
    }
}
