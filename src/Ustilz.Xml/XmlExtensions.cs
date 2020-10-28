namespace Ustilz.Xml
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The xml utils.</summary>
    [PublicAPI]
    public static class XmlExtensions
    {
        /// <summary>Méthode de dé-sérialisation à partir d'un XDocument.</summary>
        /// <param name="xDocument">Le XDocument à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="xDocument" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">
        ///     An error occurred during deserialization. The original exception is available using the
        ///     <see cref="System.Exception.InnerException"></see> property.
        /// </exception>
        [return: MaybeNull]
        public static T FromXml<T>([System.Diagnostics.CodeAnalysis.NotNull] this XDocument xDocument)
            where T : class
        {
            if (xDocument == null)
            {
                throw new ArgumentNullException(nameof(xDocument));
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using var reader = xDocument.CreateReader();
            return xmlSerializer.Deserialize(reader) as T;
        }

        /// <summary>Méthode de dé-sérialisation à partir d'une chaine de caractère.</summary>
        /// <param name="xmlStr">La chaine de caractères à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="xmlStr">s</paramref> parameter is null.</exception>
        /// <exception cref="SecurityException">The <see cref="System.Xml.XmlReader"></see> does not have sufficient permissions to access the location of the XML data.</exception>
        /// <exception cref="FileNotFoundException">The file identified by the URI does not exist.</exception>
        /// <exception cref="UriFormatException">
        ///     In the [.NET for Windows Store apps](http://go.microsoft.com/fwlink/?LinkID=247912) or the [Portable Class
        ///     Library](~/docs/standard/cross-platform/cross-platform-development-with-the-portable-class-library.md), catch the base class exception,
        ///     <see cref="System.FormatException"></see>, instead. The URI format is not correct.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     An error occurred during deserialization. The original exception is available using the
        ///     <see cref="System.Exception.InnerException"></see> property.
        /// </exception>
        [return: MaybeNull]
        public static T FromXml<T>([System.Diagnostics.CodeAnalysis.NotNull] this string xmlStr)
            where T : class
        {
            if (xmlStr == null)
            {
                throw new ArgumentNullException(nameof(xmlStr));
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using var reader =
                XmlReader.Create(xmlStr ?? throw new ArgumentNullException(nameof(xmlStr), Resources.XmlExtensions_FromXml_La_chaine_de_caractères_ne_peut_pas_être_nulle_));
            return xmlSerializer.Deserialize(reader) as T;
        }

        /// <summary>Méthode de dé-sérialisation à partir d'un document Xml.</summary>
        /// <param name="xmlDocument">Document Xml à dé-sérialiser.</param>
        /// <typeparam name="T">Le type vers lequel dé-sérialiser.</typeparam>
        /// <returns>Retourne l'objet de T dé-sérialisé.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="xmlDocument" /> is <see langword="null" />.</exception>
        /// <exception cref="InvalidOperationException">Le document ne peut pas être null.</exception>
        [return: MaybeNull]
        public static T FromXml<T>([JetBrains.Annotations.NotNull] this XmlDocument xmlDocument)
            where T : class
        {
            if (xmlDocument == null)
            {
                throw new ArgumentNullException(nameof(xmlDocument));
            }

            var xmlSerializer = new XmlSerializer(typeof(T));
            using var reader =
                new XmlNodeReader(xmlDocument.DocumentElement ?? throw new InvalidOperationException(Resources.XmlExtensions_FromXml_Le_document_ne_peut_pas_être_null_));
            return xmlSerializer.Deserialize(reader) as T;
        }

        /// <summary>Méthode de sérialisation d'un objet.</summary>
        /// <param name="objectToDeserialize">L'objet à sérialiser.</param>
        /// <typeparam name="T">Type a sérialiser.</typeparam>
        /// <returns>Retourne une chaine de caractères représentant l'objet sous format Xml.</returns>
        /// <exception cref="InvalidOperationException">
        ///     An error occurred during serialization. The original exception is available using the
        ///     <see cref="System.Exception.InnerException"></see> property.
        /// </exception>
        public static string ToXml<T>(this T objectToDeserialize)
        {
            var doc = new XDocument();
            using var xmlWriter = doc.CreateWriter();
            var xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(xmlWriter, objectToDeserialize);
            return doc.ToString();
        }
    }
}
