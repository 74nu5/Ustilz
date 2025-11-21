namespace Ustilz.Json;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

using JetBrains.Annotations;

/// <summary>The json extensions.</summary>
[PublicAPI]
public static class JsonExtensions
{
    extension(string json)
    {
        /// <summary>Méthode de dé-sérialisation à partir d'une chaine de caractères.</summary>
        /// <typeparam name="T">Type à dé-sérialiser.</typeparam>
        /// <returns>L'objet de type T.</returns>
        public T? FromJson<T>()
            => string.IsNullOrEmpty(json)
                   ? throw new ArgumentException($"{nameof(json)} parameter is null or empty.", nameof(json))
                   : JsonSerializer.Deserialize<T>(json);
    }

    extension<T>(T objectToSerialize)
    {
        /// <summary>Méthode de sérialisation d'un objet en Json.</summary>
        /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
        /// <exception cref="ArgumentNullException">objectToSerialize is <see langword="null" />.</exception>
        public string ToJson()
            => objectToSerialize == null
                   ? throw new ArgumentNullException(nameof(objectToSerialize))
                   : JsonSerializer.Serialize(objectToSerialize, new JsonSerializerOptions { WriteIndented = false });

        /// <summary>Méthode de sérialisation d'un objet en Json formatté.</summary>
        /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
        /// <exception cref="ArgumentNullException">objectToSerialize is <see langword="null" />.</exception>
        public string ToJsonFormatted()
            => objectToSerialize == null
                   ? throw new ArgumentNullException(nameof(objectToSerialize))
                   : JsonSerializer.Serialize(objectToSerialize, new JsonSerializerOptions { WriteIndented = true });
    }
}
