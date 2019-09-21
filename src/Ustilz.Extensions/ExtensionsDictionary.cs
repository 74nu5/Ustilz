namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    #endregion

    /// <summary>The extensions dictionary.</summary>
    [JetBrains.Annotations.PublicAPI]
    public static class ExtensionsDictionary
    {
        #region Méthodes publiques

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur par défaut est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur par défaut est retournée.</returns>
        public static TValue GetOrCreate<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key)
            where TValue : new()
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = new TValue();
            dictionary[key] = ret;

            return ret;
        }

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur calculée est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <param name="valueProvider">Fonction permettant d'obtenir la valeur à insérer si la clé n'existe pas.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur calculée est retournée.</returns>
        public static TValue GetOrCreate<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, Func<TValue> valueProvider)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (valueProvider is null)
            {
                throw new ArgumentNullException(nameof(valueProvider));
            }

            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = valueProvider();
            dictionary[key] = ret;

            return ret;
        }

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur calculée est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <param name="missingValue">La valeur à insérer si la clé n'existe pas.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur calculée est retournée.</returns>
        public static TValue GetOrCreate<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, TValue missingValue)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (dictionary.TryGetValue(key, out var ret))
            {
                return ret;
            }

            ret = missingValue;
            dictionary[key] = ret;

            return ret;
        }

        /// <summary>
        ///     Méthode de suppression de plusieurs éléments dans un dictionnaire.
        /// </summary>
        /// <typeparam name="TKey">Type de la clé.</typeparam>
        /// <typeparam name="TValue">Type de la valeur.</typeparam>
        /// <param name="dictionary">Dictionnaire à modifier.</param>
        /// <param name="keys">Clés à supprimer.</param>
        public static void Remove<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, params TKey[] keys)
        {
            if (dictionary is null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            foreach (var key in keys)
            {
                dictionary.Remove(key);
            }
        }

        #endregion
    }
}
