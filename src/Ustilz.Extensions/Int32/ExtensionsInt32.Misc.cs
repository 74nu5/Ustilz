namespace Ustilz.Extensions.Int32
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public static partial class ExtensionsInt32
    {
        #region Méthodes publiques

        /// <summary>Checks if the Int32 value is a factor of the specified factor number.</summary>
        /// <exception cref="DivideByZeroException">Value is 0.</exception>
        /// <param name="value">The Int32 value to check.</param>
        /// <param name="factorNumer">The factor number.</param>
        /// <returns>Returns true if the value is a factor of the specified factor number, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool FactorOf(this int value, int factorNumer)
            => factorNumer % value == 0;

        /// <summary>Checks if the Int32 is even.</summary>
        /// <param name="value">The Int32 to check.</param>
        /// <returns>Returns true if the Int32 is even, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsEven(this int value)
            => value % 2 == 0;

        /// <summary>Checks if the Int32 value is a multiple of the given factor.</summary>
        /// <exception cref="DivideByZeroException">Factor is 0.</exception>
        /// <param name="value">The Int32 to check.</param>
        /// <param name="factor">The factor.</param>
        /// <returns>Returns true if the Int32 value is a multiple of the given factor.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsMultipleOf(this int value, int factor)
            => (value != 0) && (value % factor == 0);

        /// <summary>Checks if the Int32 is odd.</summary>
        /// <param name="value">The Int32 to check.</param>
        /// <returns>Returns true if the Int32 is odd, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsOdd(this int value)
            => value % 2 != 0;

        /// <summary>Gets the specified percentage of the number.</summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentageOf(this int number, int percent)
            => ((double)number * percent) / 100;

        /// <summary>Gets the specified percentage of the number.</summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static decimal PercentageOf(this int number, decimal percent)
            => (number * percent) / 100;

        /// <summary>Gets the specified percentage of the number.</summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentageOf(this int number, double percent)
            => (number * percent) / 100;

        /// <summary>Gets the specified percentage of the number.</summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentageOf(this int number, long percent)
            => ((double)number * percent) / 100;

        /// <summary>Gets the percentage of the number.</summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentOf(this int number, int total)
        {
            if (number <= 0)
            {
                throw new DivideByZeroException("The number must be greater than zero.");
            }

            return (total / (double)number) * 100;
        }

        /// <summary>Gets the percentage of the number.</summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentOf(this int number, double total)
        {
            if (number <= 0)
            {
                throw new DivideByZeroException("The number must be greater than zero.");
            }

            return (total / number) * 100;
        }

        /// <summary>Returns a list containing all values of the given range.</summary>
        /// <exception cref="ArgumentException">The start value can not be greater than the end value.</exception>
        /// <param name="startValue">The start of the range.</param>
        /// <param name="endValue">The end of the range.</param>
        /// <returns>Returns a list containing the specified range.</returns>
        [Pure]
        [PublicAPI]
        public static IEnumerable<int> RangeTo(this int startValue, int endValue)
        {
            if (startValue > endValue)
            {
                throw new ArgumentException(Strings.RangeTo_ValueException, nameof(startValue));
            }

            return Enumerable.Range(startValue, endValue - startValue);
        }

        /// <summary>The times.</summary>
        /// <param name="count">The count.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int count, Action action)
            => Parallel.For(0, count, (l, state) => action());

        #endregion
    }
}
