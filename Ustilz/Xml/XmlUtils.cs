namespace Ustilz.Xml
{
    #region Usings

    using System.IO;
    using System.Text;
    using System.Xml;

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
        public static string PrintXml(XmlDocument document)
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

        #endregion
    }
}