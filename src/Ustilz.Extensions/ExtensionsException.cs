namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    #endregion

    /// <summary>The extensions exception.</summary>
    [JetBrains.Annotations.PublicAPI]
    public static class ExtensionsException
    {
        #region Méthodes publiques

        /// <summary>The get messages from entire exception chain.</summary>
        /// <param name="e">The e.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string GetMessagesFromEntireExceptionChain([NotNull] this Exception e)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            // get the full error message list from the inner exceptions
            var message = new StringBuilder(e.Message);
            var count = 0;
            for (var inner = e.InnerException; inner != null; inner = inner.InnerException)
            {
                count++;
                var indent = string.Empty.PadLeft(count, '\t');
                message.Append($"{Environment.NewLine}{indent}");
                message.Append(inner.Message);
            }

            return message.ToString();
        }

        #endregion
    }
}
