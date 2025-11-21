namespace Ustilz.Extensions.Tuples;

using System;

using JetBrains.Annotations;

/// <summary>
/// Classe d'extension pour les ints.
/// </summary>
[PublicAPI]
public static class TupleIntExtensions
{
    extension((int Hour, int Minute) time)
    {
        /// <summary>
        /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes.
        /// </summary>
        /// <returns>Retourne un <see cref="TimeSpan"/> représentant une heure et minute correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
        public TimeSpan Hours()
            => TimeSpan.FromMinutes((60 * time.Hour) + time.Minute);
    }

    extension((int Hour, int Minute, int Second) time)
    {
        /// <summary>
        /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes et secondes.
        /// </summary>
        /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant une heure, minutes et secondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
        public TimeSpan Hours()
            => TimeSpan.FromSeconds((3600 * time.Hour) + (60 * time.Minute) + time.Second);
    }

    extension((int Hour, int Minute, int Second, int Milliseconds) time)
    {
        /// <summary>
        /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes, secondes et millisecondes.
        /// </summary>
        /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant une heure, minutes, secondes et millisecondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
        public TimeSpan Hours()
            => TimeSpan.FromMilliseconds((3600 * 60 * time.Hour) + (60 * 60 * time.Minute) + (60 * time.Second) + time.Milliseconds);
    }

    extension((int Minute, int Second) time)
    {
        /// <summary>
        /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant des minutes et secondes.
        /// </summary>
        /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant des minutes et secondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
        public TimeSpan Minutes()
            => TimeSpan.FromSeconds((60 * time.Minute) + time.Second);
    }
}
