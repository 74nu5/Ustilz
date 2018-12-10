namespace Ustilz.Time.Date
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Classe d'extension du type DateTime.</summary>
    public static partial class ExtensionsDateTime
    {
        #region Méthodes publiques

        /// <summary>Calcule la différence entre l'année de la date et l'heure actuelles.</summary>
        /// <param name="startDay">Date à laquelle l'age est calculé.</param>
        /// <param name="day">Date depuis l'age est calculé.</param>
        /// <returns>La différence entre l'année de la date courante et celle de la date.</returns>
        [Pure]
        [PublicAPI]
        public static (int yearAge, int monthAge, int dayAge) Age(this DateTime startDay, DateTime? day = null)
        {
            var toDay = day ?? DateTime.Now;
            if (toDay.Year - startDay.Year <= 0 &&
                (toDay.Year - startDay.Year != 0 || (startDay.Month >= toDay.Month && (startDay.Month != toDay.Month || startDay.Day > toDay.Day))))
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }

            var daysInStartDayMonth = DateTime.DaysInMonth(startDay.Year, startDay.Month);
            var daysRemain = toDay.Day + (daysInStartDayMonth - startDay.Day);

            if (toDay.Month > startDay.Month)
            {
                return (toDay.Year - startDay.Year, toDay.Month - (startDay.Month + 1) + Math.Abs(daysRemain / daysInStartDayMonth),
                           ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth);
            }

            if (toDay.Month != startDay.Month)
            {
                return (toDay.Year - 1 - startDay.Year, toDay.Month + (11 - startDay.Month) + Math.Abs(daysRemain / daysInStartDayMonth),
                           ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth);
            }

            return toDay.Day >= startDay.Day
                       ? (toDay.Year - startDay.Year, 0, toDay.Day - startDay.Day)
                       : (toDay.Year - 1 - startDay.Year, 11, DateTime.DaysInMonth(startDay.Year, startDay.Month) - (startDay.Day - toDay.Day));
        }

        /// <summary>Défini une heure pour une date donnée.</summary>
        /// <param name="date">Date à modifier.</param>
        /// <param name="hours">Heure à définir.</param>
        /// <returns>Retourne la date avec l'heure définie.</returns>
        public static DateTime At(this DateTime date, int hours)
            => new DateTime(date.Year, date.Month, date.Day, hours, 0, 0);

        /// <summary>Défini une heure et les minutes pour une date donnée.</summary>
        /// <param name="date">Date à modifier.</param>
        /// <param name="hours">Heure à définir.</param>
        /// <param name="minutes">Minutes à définir.</param>
        /// <returns>Retourne la date avec l'heure définie et les minutes.</returns>
        public static DateTime At(this DateTime date, int hours, int minutes)
            => new DateTime(date.Year, date.Month, date.Day, hours, minutes, 0);

        /// <summary>Défini l'heure, les minutes et les secondes pour une date donnée.</summary>
        /// <param name="date">Date à modifier.</param>
        /// <param name="hours">Heure à définir.</param>
        /// <param name="minutes">Minutes à définir.</param>
        /// <param name="seconds">Secondes à définir.</param>
        /// <returns>Retourne la date avec l'heure définie.</returns>
        public static DateTime At(this DateTime date, int hours, int minutes, int seconds)
            => new DateTime(date.Year, date.Month, date.Day, hours, minutes, seconds);

        /// <summary>Calcule le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</summary>
        /// <param name="dateTime">La date fournie.</param>
        /// <returns>Retourne le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan Elapsed(this DateTime dateTime)
            => DateTime.Now - dateTime;

        #endregion
    }
}
