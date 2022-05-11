namespace Ustilz.Json;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

using JetBrains.Annotations;

/// <summary>The json extensions.</summary>
[PublicAPI]
public static class JsonExtensions
{
    /// <summary>Méthode de dé-sérialisation à partir d'une chaine de caractères.</summary>
    /// <param name="json">La chaine de caractères représentant le json à dé-sérialiser.</param>
    /// <typeparam name="T">Type à dé-sérialiser.</typeparam>
    /// <returns>L'objet de type T.</returns>
    [return: MaybeNull]
    public static T FromJson<T>(this string json)
        => string.IsNullOrEmpty(json)
               ? throw new ArgumentException($"{nameof(json)} parameter is null or empty.", nameof(json))
               : JsonSerializer.Deserialize<T>(json);

    /// <summary>Méthode de sérialisation d'un objet en Json.</summary>
    /// <param name="objectToSerialize">L'objet à sérialiser.</param>
    /// <typeparam name="T">Type à partir duquel sérialiser.</typeparam>
    /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="objectToSerialize" /> is <see langword="null" />.</exception>
    public static string ToJson<T>([JetBrains.Annotations.NotNull] this T objectToSerialize)
        => objectToSerialize == null
               ? throw new ArgumentNullException(nameof(objectToSerialize))
               : JsonSerializer.Serialize(objectToSerialize, new JsonSerializerOptions { WriteIndented = false });

    /// <summary>Méthode de sérialisation d'un objet en Json formatté.</summary>
    /// <param name="objectToSerialize">L'objet à sérialiser.</param>
    /// <typeparam name="T">Type à partir duquel sérialiser.</typeparam>
    /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="objectToSerialize" /> is <see langword="null" />.</exception>
    public static string ToJsonFormatted<T>([JetBrains.Annotations.NotNull] this T objectToSerialize) => objectToSerialize == null
                                                                                                             ? throw new ArgumentNullException(nameof(objectToSerialize))
                                                                                                             : JsonSerializer.Serialize(objectToSerialize, new JsonSerializerOptions { WriteIndented = true });
}