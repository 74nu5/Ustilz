namespace Ustilz.Utils
{
    #region Usings

    using System;
    using System.Resources;

    #endregion

    /// <summary>
    /// Classe d'accès aux ressources.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    internal static class SR
    {
        #region Champs et constantes statiques

        private static ResourceManager resourceManager;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient le message "Enumeration yielded no results".</summary>
        internal static string EmptyEnumerable => GetResourceString("EmptyEnumerable", @"Enumeration yielded no results");

        /// <summary>Obtient le message "Sequence contains more than one element".</summary>
        internal static string MoreThanOneElement => GetResourceString("MoreThanOneElement", @"Sequence contains more than one element");

        /// <summary>Obtient le message "Sequence contains more than one matching element".</summary>
        internal static string MoreThanOneMatch => GetResourceString("MoreThanOneMatch", @"Sequence contains more than one matching element");

        /// <summary>Obtient le message "Sequence contains no elements".</summary>
        internal static string NoElements => GetResourceString("NoElements", @"Sequence contains no elements");

        /// <summary>Obtient le message "Sequence contains no matching element".</summary>
        internal static string NoMatch => GetResourceString("NoMatch", @"Sequence contains no matching element");

        private static ResourceManager ResourceManager => resourceManager ?? (resourceManager = new ResourceManager(typeof(SR)));

        #endregion

        private static string GetResourceString(string resourceKey, string defaultString = null)
        {
            string resourceString = null;
            try
            {
                resourceString = ResourceManager.GetString(resourceKey);
            }
            catch (MissingManifestResourceException)
            {
            }

            if (defaultString != null && resourceKey.Equals(resourceString, StringComparison.Ordinal))
            {
                return defaultString;
            }

            return resourceString;
        }
    }
}
