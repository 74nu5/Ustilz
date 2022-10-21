namespace Ustilz.Extensions;

using System;
using System.Collections.Generic;

using JetBrains.Annotations;

/// <summary>The extensions list. </summary>
[PublicAPI]
internal static class ExtensionsIList
{
    /// <summary>The index of. </summary>
    /// <param name="tab">The tab. </param>
    /// <param name="value">The value. </param>
    /// <returns>The <see cref="int" />. </returns>
    /// <exception cref="ArgumentOutOfRangeException">index is not a valid index in the <see cref="IList{T}"></see>.</exception>
    /// <exception cref="NotSupportedException">The property is set and the <see cref="IList{T}"></see> is read-only.</exception>
    internal static int IndexOf(
        this IList<string> tab,
        string value)
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