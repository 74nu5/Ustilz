namespace Ustilz.Time
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    using static Duration;

    #endregion

    /// <summary>Classe d'extension de l'énumération <see cref="Duration" />.</summary>
    [PublicAPI]
    public static class ExtensionsDuration
    {
        #region Méthodes publiques

        /// <summary>Méthode calcul de projection d'une date.</summary>
        /// <param name="duration">Durée de la projection.</param>
        /// <param name="dateTime">Date à partir de laquelle la projection est faite.</param>
        /// <returns>Retourne la date projétée.</returns>
        public static DateTime From(this Duration duration, DateTime dateTime)
        {
            switch (duration)
            {
                case Second:
                    return dateTime.AddSeconds(1);
                case Minute:
                    return dateTime.AddMinutes(1);
                case Hour:
                    return dateTime.AddHours(1);
                case HalfDay:
                    return dateTime.AddHours(12);
                case Day:
                    return dateTime.AddDays(1);
                case Week:
                    return dateTime.AddDays(7);
                case Month:
                    return dateTime.AddMonths(1);
                case Quarter:
                    return dateTime.AddMonths(3);
                case Semester:
                    return dateTime.AddMonths(6);
                case Year:
                    return dateTime.AddYears(1);
                case Decade:
                    return dateTime.AddYears(10);
                default:
                    throw new ArgumentOutOfRangeException(nameof(duration));
            }
        }

        #endregion
    }
}
