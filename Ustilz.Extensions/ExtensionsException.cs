namespace Ustilz.Extensions
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions exception.</summary>
    [PublicAPI]
    public static class ExtensionsException
    {
        #region Méthodes publiques

        /// <summary>The get messages from entire exception chain.</summary>
        /// <param name="e">The e.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string GetMessagesFromEntireExceptionChain([NotNull] this Exception e)
        {
            // get the full error message list from the inner exceptions
            var message = e.Message;
            var count = 0;
            for (var inner = e.InnerException; inner != null; inner = inner.InnerException)
            {
                count++;
                var indent = string.Empty.PadLeft(count, '\t');
                message += Environment.NewLine + indent;
                message += inner.Message;
            }

            return message;
        }

        #endregion
    }
}
