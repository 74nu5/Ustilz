#pragma warning disable 1570
namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary> The extensions t. </summary>
    [PublicAPI]
    public static class ExtensionsT
    {
        #region Méthodes publiques

        /// <summary>The between. </summary>
        /// <param name="value">The value. </param>
        /// <param name="from">The from. </param>
        /// <param name="to">The to. </param>
        /// <typeparam name="T">Type à comparer </typeparam>
        /// <returns>The <see cref="bool"/>. </returns>
        public static bool Between<T>([NotNull] this T value, T from, T to)
            where T : IComparable<T> => value.CompareTo(from) >= 0 && value.CompareTo(to) <= 0;

        /// <summary>The dump. </summary>
        /// <param name="o">The o. </param>
        /// <typeparam name="T">The Type </typeparam>
        /// <returns>The <see cref="T"/>. </returns>
        public static T Dump<T>(this T o)
        {
            if (o is IEnumerable list)
            {
                var enumerable = list as object[] ?? list.Cast<object>().ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", enumerable.Select(t => t.Dump()).ToArray()));
                return o;
            }

            Console.WriteLine(o);
            return o;
        }

        /// <summary>The in. </summary>
        /// <param name="value">The value. </param>
        /// <param name="list">The list. </param>
        /// <typeparam name="T">Type de la liste </typeparam>
        /// <returns>The <see cref="bool"/>. </returns>
        public static bool IsIn<T>(this T value, params T[] list) => list.Contains(value);

        /// <summary>Determines whether [is not null].</summary>
        /// <typeparam name="T">Type de l'objet</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool IsNotNull<T>([CanBeNull] this T source)
            where T : class => source != null;

        /// <summary>The is null. </summary>
        /// <param name="source">The source. </param>
        /// <typeparam name="T">Le type à tester </typeparam>
        /// <returns>The <see cref="bool"/>. </returns>
        public static bool IsNull<T>([CanBeNull] this T source)
            where T : class => source == null;

        /// <summary>The join. </summary>
        /// <param name="tab">The tab. </param>
        /// <param name="separateur">The separateur. </param>
        /// <typeparam name="T">The type </typeparam>
        /// <returns>The <see cref="string"/>. </returns>
        public static string Join<T>(this IEnumerable<T> tab, string separateur) => string.Join(separateur, tab);

        /// <summary>Returns characters from left of specified length</summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of charaters to return</param>
        /// <returns>Returns string from left</returns>
        [CanBeNull]
        public static string Left([CanBeNull] this string value, int length) => value != null && value.Length > length ? value.Substring(0, length) : value;

        /// <summary>Returns characters from right of specified length</summary>
        /// <param name="value">String value</param>
        /// <param name="length">Max number of charaters to return</param>
        /// <returns>Returns string from right</returns>
        [CanBeNull]
        public static string Right([CanBeNull] this string value, int length) => value != null && value.Length > length ? value.Substring(value.Length - length) : value;

        /// <summary>The to.</summary>
        /// <param name="value">The value.</param>
        /// <typeparam name="T">Type to convert</typeparam>
        /// <returns>The <see cref="T"/>.</returns>
        public static T To<T>([CanBeNull] this IConvertible value)
        {
            try
            {
                var t = typeof(T);
                var u = Nullable.GetUnderlyingType(t);

                if (u != null)
                {
                    if (value == null || value.Equals(string.Empty))
                    {
                        return default(T);
                    }

                    return (T)Convert.ChangeType(value, u);
                }

                if (value == null || value.Equals(string.Empty))
                {
                    return default(T);
                }

                return (T)Convert.ChangeType(value, t);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>The to.</summary>
        /// <param name="value">The value.</param>
        /// <param name="ifError">The if error.</param>
        /// <typeparam name="T">Type to convert</typeparam>
        /// <returns>The <see cref="T"/>.</returns>
        public static T To<T>([CanBeNull] this IConvertible value, IConvertible ifError)
        {
            try
            {
                var t = typeof(T);
                var u = Nullable.GetUnderlyingType(t);

                if (u != null)
                {
                    if (value == null || value.Equals(string.Empty))
                    {
                        return (T)ifError;
                    }

                    return (T)Convert.ChangeType(value, u);
                }

                if (value == null || value.Equals(string.Empty))
                {
                    return ifError.To<T>();
                }

                return (T)Convert.ChangeType(value, t);
            }
            catch
            {
                return (T)ifError;
            }
        }

        #endregion
    }
}
#pragma warning restore 1570
