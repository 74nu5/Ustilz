namespace Ustilz.Parsers.Extensions;

/// <summary>
///     Extensions for <see cref="Span{T}" />.
/// </summary>
internal static class SpanExtensions
{
    /// <summary>
    ///     Returns the index of the n-th occurrence of a value in a <see cref="Span{T}" />.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the <see cref="Span{T}" />.</typeparam>
    /// <param name="span">The <see cref="Span{T}" /> in which to search.</param>
    /// <param name="value">The value to search for.</param>
    /// <param name="n">The occurrence number to search for. The first occurrence is at index 0.</param>
    /// <returns>The index of the n-th occurrence of the value in the <see cref="Span{T}" />. If the value is not found, returns -1.</returns>
    public static int NthIndexOf<T>(this Span<T> span, T value, int n)
            where T : IEquatable<T>
    {
        var currentIndex = -1;

        for (var i = 0; i < n; i++)
        {
            var index = span[(currentIndex + 1)..].IndexOf(value);

            if (index == -1)
                return -1;

            currentIndex += index + 1;
        }

        return currentIndex;
    }
}
