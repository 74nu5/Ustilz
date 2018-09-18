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

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur par défaut est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur par défaut est retournée.</returns>
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

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur calculée est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <param name="valueProvider">Fonction permettant d'obtenir la valeur à insérer si la clé n'existe pas.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur calculée est retournée.</returns>
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

        /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur calculée est créé avec la clé fournie.</summary>
        /// <param name="dictionary">Le dictionnaire.</param>
        /// <param name="key">La clé.</param>
        /// <param name="missingValue">La valeur à insérer si la clé n'existe pas.</param>
        /// <typeparam name="TKey">Le type de la clé.</typeparam>
        /// <typeparam name="TValue">Le type de la valeur.</typeparam>
        /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur calculée est retournée.</returns>
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

        /// <summary>
        ///     Méthode de suppression de plusieurs éléments dans un dictionnaire.
        /// </summary>
        /// <typeparam name="TKey">Type de la clé.</typeparam>
        /// <typeparam name="TValue">Type de la valeur.</typeparam>
        /// <param name="dictionary">Dictionnaire à modifier.</param>
        /// <param name="keys">Clés à supprimer.</param>
        public static void Remove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, params TKey[] keys)
        {
            foreach (var key in keys)
            {
                dictionary.Remove(key);
            }
        }

        #endregion
    }
}
