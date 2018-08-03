namespace Ustilz.Extensions.Date
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>
    /// Classe d'extension du type DateTime
    /// </summary>
    public static partial class ExtensionsDateTime
    {
        #region Méthodes publiques

        /// <summary>Calculates the difference between the year of the current and the given date time.</summary>
        /// <param name="bday">Date from age is calculate.</param>
        /// <param name="day">Date to age is calculate.</param>
        /// <returns>The difference between the year of the current and the given date time.</returns>
        [Pure]
        [PublicAPI]
        public static (int yearAge, int monthAge, int dayAge) Age(this DateTime bday, DateTime? day = null)
        {
            var cday = day ?? DateTime.Now;
            if (cday.Year - bday.Year <= 0 && (cday.Year - bday.Year != 0 || (bday.Month >= cday.Month && (bday.Month != cday.Month || bday.Day > cday.Day))))
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }

            var daysInBdayMonth = DateTime.DaysInMonth(bday.Year, bday.Month);
            var daysRemain = cday.Day + (daysInBdayMonth - bday.Day);

            return cday.Month > bday.Month
                ? (cday.Year - bday.Year, cday.Month - (bday.Month + 1) + Math.Abs(daysRemain / daysInBdayMonth),
                    ((daysRemain % daysInBdayMonth) + daysInBdayMonth) % daysInBdayMonth)
                : (cday.Month == bday.Month
                    ? (cday.Day >= bday.Day
                        ? (cday.Year - bday.Year, 0, cday.Day - bday.Day)
                        : (cday.Year - 1 - bday.Year, 11, DateTime.DaysInMonth(bday.Year, bday.Month) - (bday.Day - cday.Day)))
                    : (cday.Year - 1 - bday.Year, cday.Month + (11 - bday.Month) + Math.Abs(daysRemain / daysInBdayMonth),
                        ((daysRemain % daysInBdayMonth) + daysInBdayMonth) % daysInBdayMonth));
        }

        /// <summary>Returns a DateTime with its value set to Now minus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime Ago(this TimeSpan value)
            => DateTime.Now.Subtract(value);

        /// <summary>Returns a DateTime with its value set to Now minus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime" />.</returns>
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
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNow(this TimeSpan value)
            => DateTime.Now.Add(value);

        /// <summary>Returns a DateTime with its value set to Now plus the provided TimeSpan value.</summary>
        /// <param name="value"></param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNowUtc(this TimeSpan value)
            => DateTime.UtcNow.Add(value);

        #endregion
    }
}
