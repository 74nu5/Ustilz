namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;

    using JetBrains.Annotations;

    using Ustilz.Time;

    #endregion

    /// <summary>Classe d'extensions des TimeSpan.</summary>
    [PublicAPI]
    [SuppressMessage("ReSharper", "MethodNameNotMeaningful", Justification = "Comprehensible")]
    public static class ExtensionsTimeSpan
    {
        #region Méthodes publiques

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The result is less than <see cref="DateTime.MinValue"></see> or greater than <see cref="DateTime.MaxValue"></see>.</exception>
        public static DateTime Ago(this TimeSpan value)
            => Clock.Now.Subtract(value);

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The result is less than <see cref="DateTime.MinValue"></see> or greater than <see cref="DateTime.MaxValue"></see>.</exception>
        public static DateTime AgoUtc(this TimeSpan value)
            => DateTime.UtcNow.Subtract(value);

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The resulting <see cref="DateTime"></see> is less than <see cref="DateTime.MinValue"></see> or greater than
        ///     <see cref="DateTime.MaxValue"></see>.
        /// </exception>
        public static DateTime FromNow(this TimeSpan value)
            => Clock.Now.Add(value);

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The resulting <see cref="DateTime"></see> is less than <see cref="DateTime.MinValue"></see> or greater than
        ///     <see cref="DateTime.MaxValue"></see>.
        /// </exception>
        public static DateTime FromNowUtc(this TimeSpan value)
            => DateTime.UtcNow.Add(value);

        #endregion
    }
}
