namespace Ustilz.Extensions
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// Classe d'extensions des TimeSpan.
    /// </summary>
    public static class ExtensionsTimeSpan
    {
        #region Méthodes publiques

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime Ago(this TimeSpan value)
            => DateTime.Now.Subtract(value);

        /// <summary>Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime AgoUtc(this TimeSpan value)
            => DateTime.UtcNow.Subtract(value);

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNow(this TimeSpan value)
            => DateTime.Now.Add(value);

        /// <summary>Retourne un DateTime avec sa valeur définie sur Now plus la valeur TimeSpan fournie.</summary>
        /// <param name="value">Durée fournie.</param>
        /// <returns>The <see cref="DateTime" />.</returns>
        public static DateTime FromNowUtc(this TimeSpan value)
            => DateTime.UtcNow.Add(value);

        #endregion
    }
}
