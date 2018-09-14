namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions dictionary.</summary>
    [PublicAPI]
    public static class ExtensionsDictionary
    {
        #region Méthodes publiques

        /// <summary>The get or create.</summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <typeparam name="TKey">Type de la clé</typeparam>
        /// <typeparam name="TValue">Type de la valeur</typeparam>
        /// <returns>The <see cref="TValue" />.</returns>
        public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
            where TValue : new()
        {
            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = new TValue();
            dictionary[key] = ret;

            return ret;
        }

        /// <summary>The get or create.</summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="valueProvider">The value provider.</param>
        /// <typeparam name="TKey">Type de la clé</typeparam>
        /// <typeparam name="TValue">Type de la valeur</typeparam>
        /// <returns>The <see cref="TValue" />.</returns>
        public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueProvider)
        {
            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = valueProvider();
            dictionary[key] = ret;

            return ret;
        }

        /// <summary>The get or create.</summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="missingValue">The missing value.</param>
        /// <typeparam name="TKey">Type de la clé</typeparam>
        /// <typeparam name="TValue">Type de la valeur</typeparam>
        /// <returns>The <see cref="TValue" />.</returns>
        public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue missingValue)
        {
            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = missingValue;
            dictionary[key] = ret;

            return ret;
        }

        #endregion
    }
}
