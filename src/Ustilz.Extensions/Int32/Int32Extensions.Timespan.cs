namespace Ustilz.Extensions.Int32;

using System;

/// <summary>The extensions int 32.</summary>
public static partial class Int32Extensions
{
    extension(int days)
    {
        /// <summary>Returns a TimeSpan representing the specified number of days.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Days()
            => TimeSpan.FromDays(days);

        /// <summary>Returns a TimeSpan representing the specified number of hours.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Hours()
            => TimeSpan.FromHours(days);

        /// <summary>Returns a TimeSpan representing the specified number of milliseconds.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Milliseconds()
            => TimeSpan.FromMilliseconds(days);

        /// <summary>Returns a TimeSpan representing the specified number of minutes.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Minutes()
            => TimeSpan.FromMinutes(days);

        /// <summary>Returns a TimeSpan representing the specified number of seconds.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Seconds()
            => TimeSpan.FromSeconds(days);

        /// <summary>Returns a TimeSpan representing the specified number of ticks.</summary>
        /// <returns>The <see cref="TimeSpan" />.</returns>
        public TimeSpan Ticks()
            => TimeSpan.FromTicks(days);
    }
}