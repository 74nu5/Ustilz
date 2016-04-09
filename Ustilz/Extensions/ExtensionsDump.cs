namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections;
    using System.Linq;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The extensions t. </summary>
    [PublicAPI]
    public static class ExtensionsDump
    {
        #region Méthodes statiques

        /// <summary>The dump. </summary>
        /// <param name="o">The o. </param>
        /// <typeparam name="T">The Type </typeparam>
        /// <returns>The <see cref="T"/>. </returns>
        public static T DumpConsole<T>(this T o)
        {
            IEnumerable list = o as IEnumerable;
            if (list != null && !(o is string))
            {
                object[] enumerable = list as object[] ?? list.Cast<object>().ToArray();
                Console.WriteLine(string.Format("[{0}]", string.Join(", ", enumerable.Select(t => t.ToString()).ToArray())));
                return o;
            }

            Console.WriteLine(o);
            return o;
        }

        #endregion
    }
}