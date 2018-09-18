namespace Ustilz.Extensions
{
    #region Usings

    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions name value collection.</summary>
    [PublicAPI]
    public static class ExtensionsNameValueCollection
    {
        #region Méthodes publiques

        /// <summary>The to dictionary.</summary>
        /// <param name="nvc">The nvc.</param>
        /// <returns>The Dictionary{string, string}.</returns>
        [NotNull]
        public static Dictionary<string, string> ToDictionary([NotNull] this NameValueCollection nvc) =>
            nvc.AllKeys.ToDictionary(k => k, k => nvc[k]);

        #endregion
    }
}
