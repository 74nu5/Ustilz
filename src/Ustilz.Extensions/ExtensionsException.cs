namespace Ustilz.Extensions;

using System;
using System.Text;

using JetBrains.Annotations;

/// <summary>The extensions exception.</summary>
[PublicAPI]
public static class ExtensionsException
{
    /// <summary>The get messages from entire exception chain.</summary>
    /// <param name="e">The e.</param>
    /// <returns>The <see cref="string" />.</returns>
    public static string GetMessagesFromEntireExceptionChain(
        this Exception e)
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
}