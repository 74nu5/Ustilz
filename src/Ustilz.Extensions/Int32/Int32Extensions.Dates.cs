namespace Ustilz.Extensions.Int32;

using System;

using JetBrains.Annotations;

/// <summary>The extensions int 32.</summary>
[PublicAPI]
public static partial class Int32Extensions
{
    extension(int day, int year)
    {
        /// <summary>
        ///     Méthode qui renvoie une date du mois d'août.
        ///     <code>
        /// 12.Août(2010); // = new DateTime(2010, 8, 12)
        /// </code>
        /// </summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Août()
            => new(year, 8, day);

        /// <summary>The avril.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Avril()
            => new(year, 4, day);

        /// <summary>The décembre.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Décembre()
            => new(year, 12, day);

        /// <summary>The février.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Février()
            => new(year, 2, day);

        /// <summary>The janvier.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Janvier()
            => new(year, 1, day);

        /// <summary>The juillet.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Juillet()
            => new(year, 7, day);

        /// <summary>The juin.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Juin()
            => new(year, 6, day);

        /// <summary>The mai.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Mai()
            => new(year, 5, day);

        /// <summary>The mars.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Mars()
            => new(year, 3, day);

        /// <summary>The novembre.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Novembre()
            => new(year, 11, day);

        /// <summary>The octobre.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Octobre()
            => new(year, 10, day);

        /// <summary>The septembre.</summary>
        /// <returns>The <see cref="System.DateTime" />.</returns>
        public DateTime Septembre()
            => new(year, 9, day);
    }

    extension(int year)
    {
        /// <summary>Returns whether the given year is a leap year or not.</summary>
        /// <returns>Returns true if the year is a leap year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public bool IsLeapYear()
            => DateTime.IsLeapYear(year);
    }
}
