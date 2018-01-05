namespace Ustilz.Xml
{
    #region Usings

    using System.Xml.Linq;
    using System.Xml.Serialization;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The xml utils.</summary>
    [PublicAPI]
    public static class XmlExtensions
    {
        #region Méthodes publiques

        /// <summary>The deserialize.</summary>
        /// <param name="xmlDocument">The xml document.</param>
        /// <typeparam name="T">Le type vers lequel désérialiser</typeparam>
        /// <returns>The <see cref="T" />.</returns>
        public static T FromXml<T>([NotNull] this XDocument xmlDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = xmlDocument.CreateReader())
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }

        /// <summary>The serialize to xml.</summary>
        /// <param name="obj">The obj.</param>
        /// <typeparam name="T">Type a sérialiser</typeparam>
        /// <returns>The <see cref="string" />.</returns>
        public static string ToXml<T>(this T obj)
        {
            var doc = new XDocument();
            using (var xmlWriter = doc.CreateWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xmlWriter, obj);
            }

            return doc.ToString();
        }

        #endregion
    }
}
