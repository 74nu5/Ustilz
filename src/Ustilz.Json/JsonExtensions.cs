namespace Ustilz.Json
{
    #region Usings

    using JetBrains.Annotations;

    using Newtonsoft.Json;

    #endregion

    /// <summary>The json extensions.</summary>
    [PublicAPI]
    public static class JsonExtensions
    {
        #region Méthodes publiques

        /// <summary>Méthode de dé-sérialisation à partir d'une chaine de caractères.</summary>
        /// <param name="json">La chaine de caractères représentant le json à dé-sérialiser.</param>
        /// <typeparam name="T">Type à dé-sérialiser.</typeparam>
        /// <returns>L'objet de type T.</returns>
        public static T FromJson<T>(this string json) => JsonConvert.DeserializeObject<T>(json);

        /// <summary>Méthode de sérialisation d'un objet en Json.</summary>
        /// <param name="obj">L'objet à sérialiser.</param>
        /// <typeparam name="T">Type à partir duquel sérialiser.</typeparam>
        /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
        public static string ToJson<T>([NotNull] this T obj) => JsonConvert.SerializeObject(obj, obj.GetType(), Formatting.None, null);

        /// <summary>Méthode de sérialisation d'un objet en Json formatté.</summary>
        /// <param name="obj">L'objet à sérialiser.</param>
        /// <typeparam name="T">Type à partir duquel sérialiser.</typeparam>
        /// <returns>Retourne une chaine de caractères représentant l'objet en paramètre.</returns>
        public static string ToJsonFormatted<T>([NotNull] this T obj) => JsonConvert.SerializeObject(obj, obj.GetType(), Formatting.Indented, null);

        #endregion
    }
}
