namespace Ustilz.Xml
{
    #region Usings

    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The xml utils.</summary>
    [PublicAPI]
    public static class XmlUtils
    {
        #region Méthodes publiques

        /// <summary>The print xml.</summary>
        /// <param name="document">The document.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string PrintXml(this XmlDocument document)
        {
            using (var str = new MemoryStream())
            {
                using (var writer = new XmlTextWriter(str, Encoding.Unicode))
                {
                    writer.Formatting = Formatting.Indented;

                    // Write the XML into a formatting XmlTextWriter
                    document.WriteContentTo(writer);
                    writer.Flush();
                }

                str.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                str.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                using (var reader = new StreamReader(str))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>The serialize to xml.</summary>
        /// <param name="obj">The obj.</param>
        /// <typeparam name="T">Type a sérialiser</typeparam>
        /// <returns>The <see cref="string"/>.</returns>
        public static string SerializeToXml<T>(this T obj)
        {
            var doc = new XDocument();
            using (var xmlWriter = doc.CreateWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xmlWriter, obj);
                xmlWriter.Close();
            }

            return doc.ToString();
        }

        /// <summary>The deserialize.</summary>
        /// <param name="xmlDocument">The xml document.</param>
        /// <typeparam name="T">Le type vers lequel désérialiser</typeparam>
        /// <returns>The <see cref="T"/>.</returns>
        public static T Deserialize<T>(this XDocument xmlDocument)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = xmlDocument.CreateReader())
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }

        #endregion
    }
}