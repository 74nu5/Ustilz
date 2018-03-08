namespace Ustilz.Extensions
{
    #region Usings

    using System;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public static partial class ExtensionsInt32
    {
        #region Méthodes publiques

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of ticks.
        /// </summary>
        public static TimeSpan Ticks(this int ticks) => TimeSpan.FromTicks(ticks);

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of milliseconds.
        /// </summary>
        public static TimeSpan Milliseconds(this int milliseconds) => TimeSpan.FromMilliseconds(milliseconds);

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of seconds.
        /// </summary>
        public static TimeSpan Seconds(this int seconds) => TimeSpan.FromSeconds(seconds);

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of minutes.
        /// </summary>
        public static TimeSpan Minutes(this int minutes) => TimeSpan.FromMinutes(minutes);

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of hours.
        /// </summary>
        public static TimeSpan Hours(this int hours) => TimeSpan.FromHours(hours);

        /// <summary>
        ///     Returns a TimeSpan representing the specified number of days.
        /// </summary>
        public static TimeSpan Days(this int days) => TimeSpan.FromDays(days);

        #endregion
    }
}