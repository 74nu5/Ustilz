namespace Ustilz.Extensions.Int32
{
    #region Usings

    using System;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public static partial class ExtensionsInt32
    {
        /// <summary>Returns a TimeSpan representing the specified number of days.</summary>
        /// <param name="days">The days.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Days(this int days)
            => TimeSpan.FromDays(days);

        /// <summary>Returns a TimeSpan representing the specified number of hours.</summary>
        /// <param name="hours">The hours.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Hours(this int hours)
            => TimeSpan.FromHours(hours);

        /// <summary>Returns a TimeSpan representing the specified number of milliseconds.</summary>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Milliseconds(this int milliseconds)
            => TimeSpan.FromMilliseconds(milliseconds);

        /// <summary>Returns a TimeSpan representing the specified number of minutes.</summary>
        /// <param name="minutes">The minutes.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Minutes(this int minutes)
            => TimeSpan.FromMinutes(minutes);

        /// <summary>Returns a TimeSpan representing the specified number of seconds.</summary>
        /// <param name="seconds">The seconds.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Seconds(this int seconds)
            => TimeSpan.FromSeconds(seconds);

        /// <summary>Returns a TimeSpan representing the specified number of ticks.</summary>
        /// <param name="ticks">The ticks.</param>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public static TimeSpan Ticks(this int ticks)
            => TimeSpan.FromTicks(ticks);
    }
}
