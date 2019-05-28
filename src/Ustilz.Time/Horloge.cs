namespace Ustilz.Time
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The horloge.</summary>
    [PublicAPI]
    public static class Horloge
    {
        #region Champs et constantes statiques

        /// <summary>The fonction.</summary>
        private static Func<DateTime> fonction;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        ///     Initialise les membres statiques de la classe <see cref="Horloge" />.
        /// </summary>
        static Horloge() => fonction = () => DateTime.Now;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient maintenant.</summary>
        /// <value>The maintenant.</value>
        public static DateTime Maintenant => fonction();

        /// <summary>Définit la fonction maintenant.</summary>
        /// <value>The fonction maintenant.</value>
        public static Func<DateTime>? SetFonctionMaintenant
        {
            set => fonction = value ?? (() => DateTime.Now);
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The reset.</summary>
        public static void Reset() => SetFonctionMaintenant = null;

        #endregion
    }
}
