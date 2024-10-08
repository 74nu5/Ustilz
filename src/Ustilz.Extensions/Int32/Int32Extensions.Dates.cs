namespace Ustilz.Extensions.Int32;

using System;

using JetBrains.Annotations;

/// <summary>The extensions int 32.</summary>
[PublicAPI]
public static partial class Int32Extensions
{
    /// <summary>
    ///     Méthode qui renvoie une date du mois d'août.
    ///     <code>
    /// 12.Août(2010); // = new DateTime(2010, 8, 12)
    /// </code>
    /// </summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Août(this int day, int year)
        => new(year, 8, day);

    /// <summary>The avril.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Avril(this int day, int year)
        => new(year, 4, day);

    /// <summary>The décembre.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Décembre(this int day, int year)
        => new(year, 12, day);

    /// <summary>The février.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Février(this int day, int year)
        => new(year, 2, day);

    /// <summary>Returns whether the given year is a leap year or not.</summary>
    /// <param name="year">The year.</param>
    /// <returns>Returns true if the year is a leap year, otherwise false.</returns>
    [Pure]
    [PublicAPI]
    public static bool IsLeapYear(this int year)
        => DateTime.IsLeapYear(year);

    /// <summary>The janvier.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Janvier(this int day, int year)
        => new(year, 1, day);

    /// <summary>The juillet.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Juillet(this int day, int year)
        => new(year, 7, day);

    /// <summary>The juin.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Juin(this int day, int year)
        => new(year, 6, day);

    /// <summary>The mai.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Mai(this int day, int year)
        => new(year, 5, day);

    /// <summary>The mars.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Mars(this int day, int year)
        => new(year, 3, day);

    /// <summary>The novembre.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Novembre(this int day, int year)
        => new(year, 11, day);

    /// <summary>The octobre.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Octobre(this int day, int year)
        => new(year, 10, day);

    /// <summary>The septembre.</summary>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns>The <see cref="System.DateTime" />.</returns>
    public static DateTime Septembre(this int day, int year)
        => new(year, 9, day);
}
