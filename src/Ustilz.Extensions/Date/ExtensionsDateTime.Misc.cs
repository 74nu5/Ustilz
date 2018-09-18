namespace Ustilz.Extensions.Date
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>
    ///     Classe d'extension du type DateTime.
    /// </summary>
    public static partial class ExtensionsDateTime
    {
        #region Méthodes publiques

        /// <summary>
        /// Calcule la différence entre l'année de la date et l'heure actuelles.</summary>
        /// <param name="startDay">Date à laquelle l'age est calculé.</param>
        /// <param name="day">Date depuis l'age est calculé.</param>
        /// <returns>La différence entre l'année de la date courante et celle de la date.</returns>
        [Pure]
        [PublicAPI]
        public static (int yearAge, int monthAge, int dayAge) Age(this DateTime startDay, DateTime? day = null)
        {
            var toDay = day ?? DateTime.Now;
            if ((toDay.Year - startDay.Year <= 0) && ((toDay.Year - startDay.Year != 0) || ((startDay.Month >= toDay.Month) && ((startDay.Month != toDay.Month) || (startDay.Day > toDay.Day)))))
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }

            var daysInStartDayMonth = DateTime.DaysInMonth(startDay.Year, startDay.Month);
            var daysRemain = toDay.Day + (daysInStartDayMonth - startDay.Day);

            return toDay.Month > startDay.Month
                ? (toDay.Year - startDay.Year, (toDay.Month - (startDay.Month + 1)) + Math.Abs(daysRemain / daysInStartDayMonth),
                    ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth)
                : toDay.Month == startDay.Month
                    ? toDay.Day >= startDay.Day
                        ? (toDay.Year - startDay.Year, 0, toDay.Day - startDay.Day)
                        : (toDay.Year - 1 - startDay.Year, 11, DateTime.DaysInMonth(startDay.Year, startDay.Month) - (startDay.Day - toDay.Day))
                    : (toDay.Year - 1 - startDay.Year, toDay.Month + (11 - startDay.Month) + Math.Abs(daysRemain / daysInStartDayMonth),
                        ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth);
        }

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime Ago(this TimeSpan value)
            => DateTime.Now.Subtract(value);

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime AgoUtc(this TimeSpan value)
            => DateTime.UtcNow.Subtract(value);

        /// <summary>Calcule le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</summary>
        /// <param name="dateTime">La date fournie.</param>
        /// <returns>Retourne le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan Elapsed(this DateTime dateTime)
            => DateTime.Now - dateTime;

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNow(this TimeSpan value)
            => DateTime.Now.Add(value);

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNowUtc(this TimeSpan value)
            => DateTime.UtcNow.Add(value);

        #endregion
    }
}
