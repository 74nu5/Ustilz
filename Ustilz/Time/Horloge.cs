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
        private static Func<DateTime> _fonction = () => DateTime.Now;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the maintenant.</summary>
        /// <value>The maintenant.</value>
        public static DateTime Maintenant => _fonction();

        /// <summary>Sets the fonction maintenant.</summary>
        /// <value>The fonction maintenant.</value>
        public static Func<DateTime> FonctionMaintenant
        {
            set => _fonction = value ?? (() => DateTime.Now);
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The reset.</summary>
        public static void Reset() => FonctionMaintenant = null;

        #endregion
    }
}
