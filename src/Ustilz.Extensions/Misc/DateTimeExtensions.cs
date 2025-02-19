namespace Ustilz.Extensions.Misc;

using JetBrains.Annotations;

/// <summary>
///     Extensions for <see cref="DateTime" />.
/// </summary>
[PublicAPI]
public static class DateTimeExtensions
{
    /// <summary>
    ///     Convert a <see cref="DateTime" /> to a Unix timestamp.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to convert.</param>
    /// <returns>The Unix timestamp.</returns>
    public static long ToUnixTimestamp(this DateTime dateTime)
        => (long)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

    /// <summary>
    ///     Convert a Unix timestamp to a <see cref="DateTime" />.
    /// </summary>
    /// <param name="unixTimestamp">The Unix timestamp to convert.</param>
    /// <returns>The <see cref="DateTime" />.</returns>
    public static DateTime ToDateTime(this long unixTimestamp)
        => new DateTime(1970, 1, 1).AddSeconds(unixTimestamp);

    /// <summary>
    ///     Brings a date to its end of month date.
    /// </summary>
    /// <param name="source">The source date.</param>
    /// <returns>The transformed date.</returns>
    public static DateTime ToLastDayOfMonth(this DateTime source)
        => new(source.Year, source.Month, DateTime.DaysInMonth(source.Year, source.Month));

    /// <summary>
    ///     Brings a date to its start of month date.
    /// </summary>
    /// <param name="source">The source date.</param>
    /// <returns>The transformed date.</returns>
    public static DateTime ToFirstDayOfMonth(this DateTime source)
        => new(source.Year, source.Month, 1);

    /// <summary>
    ///     Indicates if it is a weekend day.
    /// </summary>
    /// <param name="date">Date to test.</param>
    /// <returns><see langword="true" /> if it is a weekend day, <see langword="false" /> otherwise.</returns>
    public static bool IsWeekEnd(this DateTime date)
        => date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

    /// <summary>
    ///     Indicates if the day is a holiday.
    /// </summary>
    /// <param name="dtDate">The date to check.</param>
    /// <returns>Returns a boolean.</returns>
    public static bool IsFerie(this DateTime dtDate)
    {
        var result = dtDate switch
        {
            // New Year's Day
            { Month: 1, Day: 1 } => true,

            // Labor Day
            { Month: 5, Day: 1 } => true,

            // Victory in Europe Day
            { Month: 5, Day: 8 } => true,

            // Bastille Day
            { Month: 7, Day: 14 } => true,

            // Assumption of Mary
            { Month: 8, Day: 15 } => true,

            // All Saints' Day
            { Month: 11, Day: 1 } => true,

            // Armistice Day
            { Month: 11, Day: 11 } => true,

            // Christmas
            { Month: 12, Day: 25 } => true,
            _ => false,
        };

        if (result)
            return true;

        // Calculation of Easter Sunday (Oudin's algorithm (1940))
        // Calculation of the golden number - 1
        var intGoldNumber = dtDate.Year % 19;

        // Year divided by one hundred
        var intAnneeDiv100 = dtDate.Year / 100;

        // intEpacte is = 23 - Epacte (modulo 30)
        var intEpacte = (intAnneeDiv100 - intAnneeDiv100 / 4 - (8 * intAnneeDiv100 + 13) / 25 + 19 * intGoldNumber + 15) % 30;

        // The number of days from March 21 to reach the Paschal full moon
        var intDaysEquinoxeToMoonFull = intEpacte - intEpacte / 28 * (1 - intEpacte / 28 * (29 / (intEpacte + 1)) * ((21 - intGoldNumber) / 11));

        // Day of the week for the Paschal full moon (0=Sunday)
        var intWeekDayMoonFull = (dtDate.Year + dtDate.Year / 4 + intDaysEquinoxeToMoonFull + 2 - intAnneeDiv100 + intAnneeDiv100 / 4) % 7;

        // Number of days from March 21 to the Sunday on or before the Paschal full moon (a number between -6 and 28)
        var intDaysEquinoxeBeforeFullMoon = intDaysEquinoxeToMoonFull - intWeekDayMoonFull;

        // Month of Easter
        var intMonthPaques = 3 + (intDaysEquinoxeBeforeFullMoon + 40) / 44;

        // Day of Easter
        var intDayPaques = intDaysEquinoxeBeforeFullMoon + 28 - 31 * (intMonthPaques / 4);

        // Easter Monday
        var dtMondayPaques = new DateTime(dtDate.Year, intMonthPaques, intDayPaques).AddDays(1);

        // Ascension
        var dtAscension = dtMondayPaques.AddDays(38);

        // Pentecost
        var dtMondayPentecote = dtMondayPaques.AddDays(49);

        result = DateTime.Compare(dtMondayPaques, dtDate) == 0
              || DateTime.Compare(dtAscension, dtDate) == 0
              || DateTime.Compare(dtMondayPentecote, dtDate) == 0;

        return result;
    }
}
