namespace Ustilz.Time
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The horloge.</summary>
    [PublicAPI]
    [SuppressMessage("ReSharper", "EventExceptionNotDocumented", Justification = "Improbable")]
    public static class Horloge
    {
        #region Champs et constantes statiques

        /// <summary>The fonction.</summary>
        private static Func<DateTime> fonction = () => DateTime.Now;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient maintenant.</summary>
        /// <value>The maintenant.</value>
        public static DateTime Maintenant => fonction?.Invoke() ?? DateTime.Now;

        /// <summary>Définit la fonction maintenant.</summary>
        /// <param name="value">The fonction maintenant.</param>
        public static void SetFonctionMaintenant(Func<DateTime> value)
            => fonction = value ?? (() => DateTime.Now);

        #endregion

        #region Méthodes publiques

        /// <summary>The reset.</summary>
        public static void Reset() => fonction = () => DateTime.Now;

        #endregion
    }
}
