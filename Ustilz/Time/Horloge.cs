namespace Ustilz.Time
{
    #region Usings

    using System;

    using Ustilz.Annotations;

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

        /// <summary>Initializes static members of the <see cref="Horloge"/> class.</summary>
        static Horloge()
        {
            fonction = () => DateTime.Now;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the maintenant.</summary>
        /// <value>The maintenant.</value>
        public static DateTime Maintenant => fonction();

        /// <summary>Sets the fonction maintenant.</summary>
        /// <value>The fonction maintenant.</value>
        public static Func<DateTime> FonctionMaintenant
        {
            set
            {
                fonction = value ?? (() => DateTime.Now);
            }
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The reset.</summary>
        public static void Reset()
        {
            FonctionMaintenant = null;
        }

        #endregion
    }
}