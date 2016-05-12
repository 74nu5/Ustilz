namespace Ustilz.Extensions
{
    #region Usings

    using System;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public static class ExtensionsInt32
    {
        #region Méthodes publiques

        /// <summary>The août.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Août(this int day, int year)
        {
            return new DateTime(year, 8, day);
        }

        /// <summary>The avril.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Avril(this int day, int year)
        {
            return new DateTime(year, 4, day);
        }

        /// <summary>The décembre.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Décembre(this int day, int year)
        {
            return new DateTime(year, 12, day);
        }

        /// <summary>The février.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Février(this int day, int year)
        {
            return new DateTime(year, 2, day);
        }

        /// <summary>The janvier.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Janvier(this int day, int year)
        {
            return new DateTime(year, 1, day);
        }

        /// <summary>The juillet.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Juillet(this int day, int year)
        {
            return new DateTime(year, 7, day);
        }

        /// <summary>The juin.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Juin(this int day, int year)
        {
            return new DateTime(year, 6, day);
        }

        /// <summary>The mai.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Mai(this int day, int year)
        {
            return new DateTime(year, 5, day);
        }

        /// <summary>The mars.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Mars(this int day, int year)
        {
            return new DateTime(year, 3, day);
        }

        /// <summary>The novembre.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Novembre(this int day, int year)
        {
            return new DateTime(year, 11, day);
        }

        /// <summary>The octobre.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Octobre(this int day, int year)
        {
            return new DateTime(year, 10, day);
        }

        /// <summary>The septembre.</summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Septembre(this int day, int year)
        {
            return new DateTime(year, 9, day);
        }

        #endregion
    }
}