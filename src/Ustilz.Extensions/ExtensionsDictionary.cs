namespace Ustilz.Extensions;

using System;
using System.Collections.Generic;

using JetBrains.Annotations;

/// <summary>The extensions dictionary.</summary>
[PublicAPI]
public static class ExtensionsDictionary
{
    /// <summary>Méthode d'ajout ou de mise à jour de valeur dans un dictionnaire.</summary>
    /// <typeparam name="TKey">Type de la clé du dictionnaire.</typeparam>
    /// <typeparam name="TValue">Type de la valeur du dictionnaire.</typeparam>
    /// <param name="dictionary">Dictionnaire à modifier.</param>
    /// <param name="key">Clé de l'élément à ajouter/modifier.</param>
    /// <param name="value">Valeur de l'élément à ajouter/modifier.</param>
    /// <returns>Retourn True si la clé existe déjà, False sinon.</returns>
    public static bool AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        where TKey : notnull
    {
        _ = dictionary ?? throw new ArgumentNullException(nameof(dictionary));

        if (dictionary.ContainsKey(key))
        {
            dictionary[key] = value;
            return true;
        }

        dictionary.Add(key, value);
        return false;
    }

    /// <summary>Méthode qui obtient une valeur d'un dictionnaire, si la clé n'existe pas la valeur par défaut est créé avec la clé fournie.</summary>
    /// <param name="dictionary">Le dictionnaire.</param>
    /// <param name="key">La clé.</param>
    /// <typeparam name="TKey">Le type de la clé.</typeparam>
    /// <typeparam name="TValue">Le type de la valeur.</typeparam>
    /// <returns>Retourne la valeur associé à la clé, si la clé n'existe pas la valeur par défaut est retournée.</returns>
    public static TValue GetOrCreate<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        [System.Diagnostics.CodeAnalysis.NotNull]
        TKey key)
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

        ret = new();
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
    public static TValue GetOrCreate<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        [System.Diagnostics.CodeAnalysis.NotNull]
        TKey key,
        Func<TValue> valueProvider)
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
    public static TValue GetOrCreate<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        [System.Diagnostics.CodeAnalysis.NotNull]
        TKey key,
        TValue missingValue)
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

    /// <summary>Méthode de suppression de plusieurs éléments dans un dictionnaire.</summary>
    /// <typeparam name="TKey">Type de la clé.</typeparam>
    /// <typeparam name="TValue">Type de la valeur.</typeparam>
    /// <param name="dictionary">Dictionnaire à modifier.</param>
    /// <param name="keys">Clés à supprimer.</param>
    public static void Remove<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        params TKey[] keys)
    {
        _ = dictionary ?? throw new ArgumentNullException(nameof(dictionary));

        foreach (var key in keys)
        {
            dictionary.Remove(key);
        }
    }
}
