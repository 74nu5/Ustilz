namespace Ustilz.Extensions
{
    #region Usings

    using System;

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
            Console.WriteLine(o);
            return o;
        }

        #endregion
    }
}