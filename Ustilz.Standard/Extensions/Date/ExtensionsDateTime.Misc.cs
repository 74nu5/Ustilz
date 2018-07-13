namespace Ustilz.Extensions.Date
{
    using System;

    using JetBrains.Annotations;

    public static partial class ExtensionsDateTime
    {
        #region Méthodes publiques

        /// <summary>Calculates the difference between the year of the current and the given date time.</summary>
        /// <remarks><paramref name="now"/> can be smaller than <paramref name="dateTime"/>, which results in negative results.
        ///     Source from: http://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c</remarks>
        /// <param name="dateTime">The date time value.</param>
        /// <param name="now">The 'current' date used to calculate the age, or null to use <see cref="DateTime.Now"/>.</param>
        /// <returns>The difference between the year of the current and the given date time.</returns>
        [Pure]
        [PublicAPI]
        public static int Age(this DateTime dateTime, [CanBeNull] DateTime? now = null)
        {
            var currentDate = now ?? DateTime.Now;
            if (dateTime.Year == currentDate.Year)
            {
                return 0;
            }

            var a = (currentDate.Year * 100 + currentDate.Month) * 100 + currentDate.Day;
            var b = (dateTime.Year * 100 + dateTime.Month) * 100 + dateTime.Day;

            return (a - b) / 10000;
        }

        /// <summary>Returns a DateTime with its value set to Now minus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Ago(this TimeSpan value)
            => DateTime.Now.Subtract(value);

        /// <summary>Returns a DateTime with its value set to Now minus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime AgoUtc(this TimeSpan value)
            => DateTime.UtcNow.Subtract(value);

        /// <summary>Calculates the elapsed time between the given date time value and DateTime.Now.</summary>
        /// <param name="dateTime">The date time value.</param>
        /// <returns>Returns the elapsed time between the given date time value and DateTime.Now.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan Elapsed(this DateTime dateTime)
            => DateTime.Now - dateTime;

        /// <summary>Returns a DateTime with its value set to Now plus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime FromNow(this TimeSpan value)
            => DateTime.Now.Add(value);

        /// <summary>Returns a DateTime with its value set to Now plus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime FromNowUtc(this TimeSpan value)
            => DateTime.UtcNow.Add(value);

        #endregion
    }
}