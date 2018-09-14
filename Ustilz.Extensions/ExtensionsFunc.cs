namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;

    using JetBrains.Annotations;

    using Ustilz.Extensions.Models;

    #endregion

    /// <summary>The extensions func. </summary>
    [PublicAPI]
    public static class ExtensionsFunc
    {
        #region Méthodes publiques

        /// <summary>Executes the given action with the value as parameter and handles any exceptions during the execution.</summary>
        /// <exception cref="ArgumentNullException">The action can not be null.</exception>
        /// <param name="action">The action.</param>
        /// <param name="value">The value.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>Returns the given value as result or an exception if one is occurred.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IExecutionResult<T> ExecuteSafe<T>([NotNull] this Action<T> action, [CanBeNull] T value)
        {
            action.ThrowIfNull(nameof(action));

            var result = new ExecutionResult<T>();
            try
            {
                action(value);
                result.Result = value;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        /// <summary>Executes the given function with the value as parameter and handles any exceptions during the execution.</summary>
        /// <exception cref="ArgumentNullException">The func can not be null.</exception>
        /// <param name="func">The function.</param>
        /// <param name="value">The value.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <returns>Returns the result of the function or an exception if one is occurred.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IExecutionResult<TResult> ExecuteSafe<T, TResult>([NotNull] this Func<T, TResult> func, [CanBeNull] T value)
        {
            func.ThrowIfNull(nameof(func));

            var result = new ExecutionResult<TResult>();
            try
            {
                result.Result = func(value);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

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
        /// <param name="timestamp">Retourne le temps d'exévution de la méthode en millisecondes. </param>
        /// <returns>La valeur de retour</returns>
        public static TResult TestPerf<TResult>([NotNull] this Func<TResult> action, out long timestamp)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = action.Invoke();

            stopWatch.Stop();
            timestamp = stopWatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>Tests the perf. </summary>
        /// <typeparam name="T">The type T </typeparam>
        /// <typeparam name="TResult">The type of the result. </typeparam>
        /// <param name="action">The action. </param>
        /// <param name="timestamp">Retourne le temps d'exévution de la méthode en millisecondes. </param>
        /// <param name="param">The parameter. </param>
        /// <returns>La valeur de retour</returns>
        public static TResult TestPerf<T, TResult>([NotNull] this Func<T, TResult> action, out long timestamp, T param)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = action.Invoke(param);

            stopWatch.Stop();
            timestamp = stopWatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>The test perf.</summary>
        /// <param name="action">The action.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="param1">The param 1.</param>
        /// <param name="param2">The param 2.</param>
        /// <typeparam name="T1">Type du premier paramètre</typeparam>
        /// <typeparam name="T2">Type du deuxième paramètre</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="TResult" />.</returns>
        public static TResult TestPerf<T1, T2, TResult>([NotNull] this Func<T1, T2, TResult> action, out long timestamp, T1 param1, T2 param2)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = action.Invoke(param1, param2);

            stopWatch.Stop();
            timestamp = stopWatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>The test perf.</summary>
        /// <param name="action">The action.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="param1">The param 1.</param>
        /// <param name="param2">The param 2.</param>
        /// <param name="param3">The param 3.</param>
        /// <typeparam name="T1">Type du premier paramètre</typeparam>
        /// <typeparam name="T2">Type du deuxième paramètre</typeparam>
        /// <typeparam name="T3">Type du troisième paramètre</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="TResult" />.</returns>
        public static TResult TestPerf<T1, T2, T3, TResult>([NotNull] this Func<T1, T2, T3, TResult> action, out long timestamp, T1 param1, T2 param2, T3 param3)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = action.Invoke(param1, param2, param3);

            stopWatch.Stop();
            timestamp = stopWatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>The test perf.</summary>
        /// <param name="action">The action.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="param1">The param 1.</param>
        /// <param name="param2">The param 2.</param>
        /// <param name="param3">The param 3.</param>
        /// <param name="param4">The param 4.</param>
        /// <typeparam name="T1">Type du premier paramètre</typeparam>
        /// <typeparam name="T2">Type du deuxième paramètre</typeparam>
        /// <typeparam name="T3">Type du troisième paramètre</typeparam>
        /// <typeparam name="T4">Type du quatrième paramètre</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="TResult" />.</returns>
        public static TResult TestPerf<T1, T2, T3, T4, TResult>([NotNull] this Func<T1, T2, T3, T4, TResult> action, out long timestamp, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var result = action.Invoke(param1, param2, param3, param4);

            stopWatch.Stop();
            timestamp = stopWatch.ElapsedMilliseconds;
            return result;
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
