namespace Ustilz.Extensions
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    using Ustilz.Time;

    #endregion

    /// <summary>The extensions date time.</summary>
    [PublicAPI]
    public static class ExtensionsDateTime
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

        /// <summary>
        ///     Calculates the elapsed time between the given date time value and DateTime.Now.
        /// </summary>
        /// <param name="dateTime">The date time value.</param>
        /// <returns>Returns the elapsed time between the given date time value and DateTime.Now.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan Elapsed(this DateTime dateTime)
            => DateTime.Now - dateTime;

        /// <summary>The readable time stamp.</summary>
        /// <param name="currentDate">The current date.</param>
        /// <returns>The <see cref="string"/>.</returns>
        [NotNull]
        public static string ReadableTimeStamp(this DateTime currentDate)
        {
            const int Second = 1;
            const int Minute = 60 * Second;
            const int Hour = 60 * Minute;
            const int Day = 24 * Hour;
            const int Month = 30 * Day;

            var ts = new TimeSpan(Horloge.Maintenant.Ticks - currentDate.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * Minute)
            {
                return ts.Seconds == 1 ? "one second ago" : $"{ts.Seconds} seconds ago";
            }

            if (delta < 2 * Minute)
            {
                return "a minute ago";
            }

            if (delta < 45 * Minute)
            {
                return $"{ts.Minutes} minutes ago";
            }

            if (delta < 90 * Minute)
            {
                return "an hour ago";
            }

            if (delta < 24 * Hour)
            {
                return $"{ts.Hours} hours ago";
            }

            if (delta < 48 * Hour)
            {
                return "yesterday";
            }

            if (delta < 30 * Day)
            {
                if (Horloge.Maintenant.Month == 3 && delta > 27 * Day)
                {
                    return "one month ago";
                }

                return $"{ts.Days} days ago";
            }

            if (delta < 12 * Month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "one month ago" : $"{months} months ago";
            }

            var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
            return years <= 1 ? "one year ago" : years + " years ago";
        }

        #endregion
    }
}