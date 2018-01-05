namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;

    using JetBrains.Annotations;

    #endregion

    /// <summary> The extensions func. </summary>
    [PublicAPI]
    public static class ExtensionsFunc
    {
        #region Méthodes publiques

        /// <summary>The memoize. </summary>
        /// <param name="func">The func. </param>
        /// <typeparam name="T">Type du paramètres d'entrée </typeparam>
        /// <typeparam name="TResult">Type du paramètres de retour </typeparam>
        /// <returns>The <see cref="Func{T,TResult}" />. </returns>
        [NotNull]
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

        /// <summary>The memoize. </summary>
        /// <param name="func">The func. </param>
        /// <typeparam name="TResult">Type de retour </typeparam>
        /// <returns>The <see cref="Func{TResult}" />. </returns>
        [NotNull]
        public static Func<TResult> Memoize<TResult>(this Func<TResult> func)
        {
            var t = new Dictionary<string, TResult>();
            return () =>
                {
                    if (t.ContainsKey(func.GetMethodInfo().Name))
                    {
                        return t[func.GetMethodInfo().Name];
                    }

                    var result = func();
                    t.Add(func.GetMethodInfo().Name, result);
                    return result;
                };
        }

        /// <summary>Tests the perf. </summary>
        /// <typeparam name="TResult">The type of the result. </typeparam>
        /// <param name="action">The action. </param>
        /// <param name="result">The result. </param>
        /// <returns>Retourne le temps d'exévution de la méthode en millisecondes</returns>
        public static long TestPerf<TResult>([NotNull] this Func<TResult> action, out TResult result)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            result = action.Invoke();

            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        /// <summary>Tests the perf. </summary>
        /// <typeparam name="T">The type T </typeparam>
        /// <typeparam name="TResult">The type of the result. </typeparam>
        /// <param name="action">The action. </param>
        /// <param name="result">The result. </param>
        /// <param name="param">The parameter. </param>
        /// <returns>Retourne le temps d'exévution de la méthode en millisecondes</returns>
        public static long TestPerf<T, TResult>([NotNull] this Func<T, TResult> action, out TResult result, T param)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            result = action.Invoke(param);

            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        /// <summary>Tests the perf. </summary>
        /// <typeparam name="T">The type T </typeparam>
        /// <param name="action">The action. </param>
        /// <param name="param">The parameter. </param>
        /// <returns>Retourne le temps d'exévution de la méthode en millisecondes</returns>
        public static long TestPerf<T>([NotNull] this Action<T> action, T param)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            action.Invoke(param);

            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        /// <summary>Tests the perf. </summary>
        /// <param name="action">The action. </param>
        /// <returns>Retourne le temps d'exévution de la méthode en millisecondes</returns>
        public static long TestPerf([NotNull] this Action action)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            action.Invoke();

            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds;
        }

        #endregion
    }
}
