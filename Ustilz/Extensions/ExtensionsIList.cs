namespace Ustilz.Extensions
{
    #region Usings

    using System.Collections.Generic;

    #endregion

    /// <summary>The extensions list. </summary>
    internal static class ExtensionsIList
    {
        #region Méthodes privées

        /// <summary>The index of. </summary>
        /// <param name="tab">The tab. </param>
        /// <param name="value">The value. </param>
        /// <returns>The <see cref="int"/>. </returns>
        internal static int IndexOf(this IList<string> tab, string value)
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

        #endregion
    }
}