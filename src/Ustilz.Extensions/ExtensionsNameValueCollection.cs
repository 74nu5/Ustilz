namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    #endregion

    /// <summary>The extensions name value collection.</summary>
    [JetBrains.Annotations.PublicAPI]
    public static class ExtensionsNameValueCollection
    {
        #region Méthodes publiques

        /// <summary>The to dictionary.</summary>
        /// <param name="nvc">The nvc.</param>
        /// <returns>The Dictionary{string, string}.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="nvc" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">keySelector produces duplicate keys for two elements.</exception>
        /// <exception cref="NotSupportedException">The collection is read-only and the operation attempts to modify the collection.</exception>
        [return: NotNull]
        public static Dictionary<string, string> ToDictionary([NotNull] this NameValueCollection nvc)
        {
            if (nvc == null)
            {
                throw new ArgumentNullException(nameof(nvc));
            }

            return nvc.AllKeys.ToDictionary(k => k, k => nvc[k]);
        }

        #endregion
    }
}
