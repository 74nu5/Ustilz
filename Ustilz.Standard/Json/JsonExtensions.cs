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

        /// <summary>The deserialize.</summary>
        /// <param name="json">The json.</param>
        /// <typeparam name="T">Type à désérialiser</typeparam>
        /// <returns>The <see cref="T" />.</returns>
        public static T FromJson<T>(this string json) => JsonConvert.DeserializeObject<T>(json);

        /// <summary>The serialize.</summary>
        /// <param name="obj">The obj.</param>
        /// <typeparam name="T">Type à partir duquel sérialiser</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        public static string ToJson<T>([NotNull] this T obj) => JsonConvert.SerializeObject(obj, obj.GetType(), Formatting.Indented, null);

        #endregion
    }
}
