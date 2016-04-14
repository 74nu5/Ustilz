namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The extensions t. </summary>
    [PublicAPI]
    public static class ExtensionsT
    {
        #region Méthodes publiques

        /// <summary>The dump. </summary>
        /// <param name="o">The o. </param>
        /// <typeparam name="T">The Type </typeparam>
        /// <returns>The <see cref="T"/>. </returns>
        public static T DumpConsole<T>(this T o)
        {
            var list = o as IEnumerable;
            if (list != null && !(o is string))
            {
                var enumerable = list as object[] ?? list.Cast<object>().ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", enumerable.Select(t => t.ToString()).ToArray()));
                return o;
            }

            Console.WriteLine(o);
            return o;
        }

        /// <summary>The between.</summary>
        /// <param name="value">The value.</param>
        /// <param name="from">The from.</param>
        /// <param name="to">The to.</param>
        /// <typeparam name="T">Type à comparer</typeparam>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool Between<T>(this T value, T from, T to) where T : IComparable<T>
        {
            return value.CompareTo(from) >= 0 && value.CompareTo(to) <= 0;
        }

        /// <summary>The is null.</summary>
        /// <param name="source">The source.</param>
        /// <typeparam name="T">Le type à tester</typeparam>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool IsNull<T>(this T source) where T : class
        {
            return source == null;
        }

        /// <summary>The in.</summary>
        /// <param name="value">The value.</param>
        /// <param name="list">The list.</param>
        /// <typeparam name="T">Type de la liste</typeparam>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool In<T>(this T value, params T[] list)
        {
            return list.Contains(value);
        }

#if NET4_6
        /// <summary>The join.</summary>
        /// <param name="tab">The tab.</param>
        /// <param name="separateur">The separateur.</param>
        /// <typeparam name="T">The type</typeparam>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Join<T>(this IEnumerable<T> tab, string separateur)
        {
            return string.Join(separateur, tab);
        }
#endif

        #endregion
    }
}