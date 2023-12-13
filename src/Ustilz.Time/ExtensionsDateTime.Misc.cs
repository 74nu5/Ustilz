namespace Ustilz.Time;

using JetBrains.Annotations;

/// <summary>Classe d'extension du type DateTime.</summary>
public static partial class ExtensionsDateTime
{
    /// <summary>Calcule la différence entre l'année de la date et l'heure actuelles.</summary>
    /// <param name="startDate">Date à laquelle l'age est calculé.</param>
    /// <param name="date">Date depuis l'age est calculé.</param>
    /// <returns>La différence entre l'année de la date courante et celle de la date.</returns>
    /// <exception cref="ArgumentException">Birthday date must be earlier than current date.</exception>
    /// <exception cref="ArgumentOutOfRangeException">month is less than 1 or greater than 12. -or- year is less than 1 or greater than 9999.</exception>
    /// <exception cref="OverflowException">value equals <see cref="int.MinValue"></see>.</exception>
    [Pure]
    [PublicAPI]
    public static (int YearAge, int MonthAge, int DayAge) AgeFrom(this DateTime startDate, DateTime? date = null)
    {
        var (year, month, day) = date ?? Clock.Now;
        var (startYear, startMonth, startDay) = startDate;

        var toDayToStartDayYear = year - startYear;
        if (toDayToStartDayYear <= 0 && (toDayToStartDayYear != 0 || (startMonth >= month && (startMonth != month || startDay > day))))
            throw new ArgumentException(Resources.ExtensionsDateTime_Age_Birthday_date_must_be_earlier_than_current_date);

        var daysInStartDayMonth = DateTime.DaysInMonth(startYear, startMonth);
        var daysRemain = day + (daysInStartDayMonth - startDay);

        if (month > startMonth)
            return (toDayToStartDayYear, month - (startMonth + 1) + Math.Abs(daysRemain / daysInStartDayMonth), ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth);

        if (month != startMonth)
            return (year - 1 - startYear, month + (11 - startMonth) + Math.Abs(daysRemain / daysInStartDayMonth), ((daysRemain % daysInStartDayMonth) + daysInStartDayMonth) % daysInStartDayMonth);

        if (day >= startDay)
            return (toDayToStartDayYear, 0, day - startDay);

        return (year - 1 - startYear, 11, DateTime.DaysInMonth(startYear, startMonth) - (startDay - day));
    }

    /// <summary>Défini une heure pour une date donnée.</summary>
    /// <param name="date">Date à modifier.</param>
    /// <param name="hours">Heure à définir.</param>
    /// <returns>Retourne la date avec l'heure définie.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     year is less than 1 or greater than 9999. -or- month is less than 1 or greater than 12. -or- day is less than 1 or greater than the
    ///     number of days in month. -or- hour is less than 0 or greater than 23. -or- minute is less than 0 or greater than 59. -or- second is less than 0 or greater than 59.
    /// </exception>
    public static DateTime AtTime(this DateTime date, int hours)
        => new(date.Year, date.Month, date.Day, hours, 0, 0);

    /// <summary>Défini une heure et les minutes pour une date donnée.</summary>
    /// <param name="date">Date à modifier.</param>
    /// <param name="hours">Heure à définir.</param>
    /// <param name="minutes">Minutes à définir.</param>
    /// <returns>Retourne la date avec l'heure définie et les minutes.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     year is less than 1 or greater than 9999. -or- month is less than 1 or greater than 12. -or- day is less than 1 or greater than the
    ///     number of days in month. -or- hour is less than 0 or greater than 23. -or- minute is less than 0 or greater than 59. -or- second is less than 0 or greater than 59.
    /// </exception>
    public static DateTime AtTime(this DateTime date, int hours, int minutes)
        => new(date.Year, date.Month, date.Day, hours, minutes, 0);

    /// <summary>Défini l'heure, les minutes et les secondes pour une date donnée.</summary>
    /// <param name="date">Date à modifier.</param>
    /// <param name="hours">Heure à définir.</param>
    /// <param name="minutes">Minutes à définir.</param>
    /// <param name="seconds">Secondes à définir.</param>
    /// <returns>Retourne la date avec l'heure définie.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     year is less than 1 or greater than 9999. -or- month is less than 1 or greater than 12. -or- day is less than 1 or greater than the
    ///     number of days in month. -or- hour is less than 0 or greater than 23. -or- minute is less than 0 or greater than 59. -or- second is less than 0 or greater than 59.
    /// </exception>
    public static DateTime AtTime(this DateTime date, int hours, int minutes, int seconds)
        => new(date.Year, date.Month, date.Day, hours, minutes, seconds);

    /// <summary>Calcule le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</summary>
    /// <param name="dateTime">La date fournie.</param>
    /// <returns>Retourne le temps écoulé entre la valeur d'heure de date donnée et DateTime.Now.</returns>
    [Pure]
    [PublicAPI]
    public static TimeSpan Elapsed(this DateTime dateTime)
        => Clock.Now - dateTime;
}
