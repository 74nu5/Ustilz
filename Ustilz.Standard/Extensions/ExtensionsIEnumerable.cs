namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions i enumerable.</summary>
    [PublicAPI]
    public static class ExtensionsIEnumerable
    {
        #region Méthodes publiques

        /// <summary>Enumerate each element in the enumeration and execute specified action</summary>
        /// <typeparam name="T">Type of enumeration</typeparam>
        /// <param name="enumerable">Enumerable collection</param>
        /// <param name="action">Action to perform</param>
        public static void ForEach<T>([NotNull] this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        /// <summary>Converts bytes collection to hexadecimal representation</summary>
        /// <param name="bytes">Bytes to convert</param>
        /// <returns>Hexadecimal representation string</returns>
        public static string ToHexString(this IEnumerable<byte> bytes) => string.Join(string.Empty, bytes.Select(b => ("0" + b.ToString("X")).Right(2)));

        /// <summary>Read only collection of any enumeration</summary>
        /// <typeparam name="T">Type of enumeration</typeparam>
        /// <param name="collection">Enumerable collection</param>
        /// <returns>ReadOnlyCollection of the collection</returns>
        public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> collection) => new List<T>(collection).AsReadOnly();

        #endregion
    }
}
