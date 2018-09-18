namespace Ustilz.Extensions
{
    #region Usings

    using System.Collections.Generic;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions list. </summary>
    [PublicAPI]
    internal static class ExtensionsIList
    {
        /// <summary>The index of. </summary>
        /// <param name="tab">The tab. </param>
        /// <param name="value">The value. </param>
        /// <returns>The <see cref="int" />. </returns>
        internal static int IndexOf([NotNull] this IList<string> tab, string value)
        {
            for (var i = 0; i < tab.Count; i++)
            {
                var el = tab[i];
                if (el == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
