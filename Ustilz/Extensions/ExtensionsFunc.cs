namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The extensions func.</summary>
    [PublicAPI]
    public static class ExtensionsFunc
    {
        #region Méthodes publiques

        /// <summary>The memoize.</summary>
        /// <param name="func">The func.</param>
        /// <typeparam name="T">Type du paramètres d'entrée</typeparam>
        /// <typeparam name="TResult">Type du paramètres de retour</typeparam>
        /// <returns>The <see cref="Func{T,TResult}"/>.</returns>
        public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
        {
            var t = new Dictionary<T, TResult>();
            return n =>
                {
                    if (t.ContainsKey(n))
                    {
                        return t[n];
                    }

                    var result = func(n);
                    t.Add(n, result);
                    return result;
                };
        }

        /// <summary>The memoize.</summary>
        /// <param name="func">The func.</param>
        /// <typeparam name="TResult">Type de retour</typeparam>
        /// <returns>The <see cref="Func{TResult}"/>.</returns>
        public static Func<TResult> Memoize<TResult>(this Func<TResult> func)
        {
            var t = new Dictionary<string, TResult>();
            return () =>
                {
                    if (t.ContainsKey(func.Method.Name))
                    {
                        return t[func.Method.Name];
                    }

                    var result = func();
                    t.Add(func.Method.Name, result);
                    return result;
                };
        }

        #endregion
    }
}