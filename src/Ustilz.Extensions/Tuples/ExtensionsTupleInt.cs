namespace Ustilz.Extensions.Tuples
{
    #region Usings

    using System;

    #endregion

    public static class ExtensionsTupleInt
    {
        public static TimeSpan Hours(this double time)
        {
            var h = Math.Round(time);
            var min = (time - h) * 60;

            return TimeSpan.FromMinutes((60 * h) + min);
        }

        public static TimeSpan Hours(this (int hour, int minute) time)
            => TimeSpan.FromMinutes((60 * time.hour) + time.minute);

        public static TimeSpan Hours(this (int hour, int minute, int second) time)
            => TimeSpan.FromSeconds((3600 * time.hour) + (60 * time.minute) + time.second);

        public static TimeSpan Hours(this (int hour, int minute, int second, int milliseconds) time)
            => TimeSpan.FromMilliseconds((3600 * 60 * time.hour) + (60 * 60 * time.minute) + (60 * time.second) + time.milliseconds);

        public static TimeSpan Minutes(this (int minute, int second) time)
            => TimeSpan.FromSeconds((60 * time.minute) + time.second);
    }
}
