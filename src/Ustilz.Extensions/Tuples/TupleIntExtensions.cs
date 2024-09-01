namespace Ustilz.Extensions.Tuples;

using System;

using JetBrains.Annotations;

/// <summary>
/// Classe d'extension pour les ints.
/// </summary>
[PublicAPI]
public static class TupleIntExtensions
{
    /// <summary>
    /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes.
    /// </summary>
    /// <param name="time">Tuple représentant les heures et les minutes.</param>
    /// <returns>Retourne un <see cref="TimeSpan"/> représentant une heure et minute correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
    public static TimeSpan Hours(this (int Hour, int Minute) time)
        => TimeSpan.FromMinutes((60 * time.Hour) + time.Minute);

    /// <summary>
    /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes et secondes.
    /// </summary>
    /// <param name="time">Tuple représentant une heure, minutes et secondes.</param>
    /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant une heure, minutes et secondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
    public static TimeSpan Hours(this (int Hour, int Minute, int Second) time)
        => TimeSpan.FromSeconds((3600 * time.Hour) + (60 * time.Minute) + time.Second);

    /// <summary>
    /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant une heure, minutes, secondes et millisecondes.
    /// </summary>
    /// <param name="time">Tuple représentant une heure, minutes, secondes et millisecondes.</param>
    /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant une heure, minutes, secondes et millisecondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
    public static TimeSpan Hours(this (int Hour, int Minute, int Second, int Milliseconds) time)
        => TimeSpan.FromMilliseconds((3600 * 60 * time.Hour) + (60 * 60 * time.Minute) + (60 * time.Second) + time.Milliseconds);

    /// <summary>
    /// Méthode de définition d'un <see cref="TimeSpan"/> à partir d'un tuple de int représentant des minutes et secondes.
    /// </summary>
    /// <param name="time">Tuple représentant des minutes et secondes.</param>
    /// <returns>Retourne un <see cref="TimeSpan"/> représentant représentant des minutes et secondes correspondant au valeur du <see cref="Tuple{T1, T2}"/>.</returns>
    public static TimeSpan Minutes(this (int Minute, int Second) time)
        => TimeSpan.FromSeconds((60 * time.Minute) + time.Second);
}
