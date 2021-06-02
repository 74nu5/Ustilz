namespace Ustilz.Time
{
    using System;

    using JetBrains.Annotations;

    using static Duration;

    /// <summary>Classe d'extension de l'énumération <see cref="Duration" />.</summary>
    [PublicAPI]
    public static class ExtensionsDuration
    {
        /// <summary>Méthode calcul de projection d'une date.</summary>
        /// <param name="duration">Durée de la projection.</param>
        /// <param name="dateTime">Date à partir de laquelle la projection est faite.</param>
        /// <returns>Retourne la date projétée.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The resulting <see cref="System.DateTime"></see> is less than <see cref="System.DateTime.MinValue"></see> or greater than
        ///     <see cref="System.DateTime.MaxValue"></see>.
        /// </exception>
        public static DateTime From(this Duration duration, DateTime dateTime)
            => duration switch
            {
                Second => dateTime.AddSeconds(1),
                Minute => dateTime.AddMinutes(1),
                Hour => dateTime.AddHours(1),
                HalfDay => dateTime.AddHours(12),
                Day => dateTime.AddDays(1),
                Week => dateTime.AddDays(7),
                Month => dateTime.AddMonths(1),
                Quarter => dateTime.AddMonths(3),
                Semester => dateTime.AddMonths(6),
                Year => dateTime.AddYears(1),
                Decade => dateTime.AddYears(10),
                var _ => throw new ArgumentOutOfRangeException(nameof(duration))
            };
    }
}
