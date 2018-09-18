namespace Ustilz.Xml
{
    #region Usings

    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The xml utils.</summary>
    [PublicAPI]
    public static class XmlExtensions
    {
        #region Méthodes publiques

        /// <summary>Méthode de dé-sérialisation à partir d'un XDocument.</summary>
        /// <param name="xDocument">Le XDocument à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        public static T FromXml<T>([NotNull] this XDocument xDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = xDocument.CreateReader())
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }

        /// <summary>Méthode de dé-sérialisation à partir d'une chaine de caractère.</summary>
        /// <param name="xmlStr">La chaine de caractères à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        public static T FromXml<T>([NotNull] this string xmlStr)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xmlStr ?? throw new NullReferenceException("La chaine de caractères ne peut pas être nulle.")))
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }

        /// <summary>Méthode de dé-sérialisation à partir d'un document Xml.</summary>
        /// <param name="xmlDocument">Document Xml à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        public static T FromXml<T>([NotNull] this XmlDocument xmlDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = new XmlNodeReader(xmlDocument.DocumentElement ?? throw new InvalidOperationException("Le document ne peut pas être null.")))
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }

        /// <summary>Méthode de sérialisation d'un objet.</summary>
        /// <param name="obj">L'objet à sérialiser.</param>
        /// <typeparam name="T">Type a sérialiser.</typeparam>
        /// <returns>Retourne une chaine de caractères représentant l'objet sous format Xml.</returns>
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
