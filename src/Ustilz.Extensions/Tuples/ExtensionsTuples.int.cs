namespace Ustilz.Extensions.Tuples
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Classe d'extensions des <see cref="Tuple{T1,T2}" /> où T et T1 sont de type <see cref="int" />.</summary>
    [PublicAPI]
    public static class ExtensionsTuples
    {
        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur en tuple (heures, minutes) à passée en paramètre.</summary>
        /// <param name="time">Valeur décimal à convertir.</param>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimen tuple (heures, minutes) passée en paramètre.</returns>
        public static TimeSpan Hours(this (int Hour, int Minute) time)
            => TimeSpan.FromMinutes((60 * time.Hour) + time.Minute);

        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur en tuple (heures, minutes, secondes) à passée en paramètre.</summary>
        /// <param name="time">Valeur décimal à convertir.</param>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimen tuple (heures, minutes, secondes) passée en paramètre.</returns>
        public static TimeSpan Hours(this (int Hour, int Minute, int Second) time)
            => TimeSpan.FromSeconds((3600 * time.Hour) + (60 * time.Minute) + time.Second);

        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur en tuple (heures, minutes, secondes, millisecondes) à passée en paramètre.</summary>
        /// <param name="time">Valeur décimal à convertir.</param>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimen tuple (heures, minutes, secondes, millisecondes) passée en paramètre.</returns>
        public static TimeSpan Hours(this (int Hour, int Minute, int Second, int Milliseconds) time)
            => TimeSpan.FromMilliseconds((3600 * 60 * time.Hour) + (60 * 60 * time.Minute) + (60 * time.Second) + time.Milliseconds);

        /// <summary>Méthode d'obtention d'un <see cref="TimeSpan" /> réprésentant la valeur en tuple (minutes, secondes) à passée en paramètre.</summary>
        /// <param name="time">Valeur décimal à convertir.</param>
        /// <returns>Retourne un <see cref="TimeSpan" /> réprésentant la valeur décimen tuple (minutes, secondes) passée en paramètre.</returns>
        public static TimeSpan Minutes(this (int Minute, int Second) time)
            => TimeSpan.FromSeconds((60 * time.Minute) + time.Second);
    }
}
