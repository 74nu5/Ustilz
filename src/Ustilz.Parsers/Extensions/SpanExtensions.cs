namespace Ustilz.Parsers.Extensions;

/// <summary>
///     Extensions for <see cref="Span{T}" />.
/// </summary>
internal static class SpanExtensions
{
    extension<T>(Span<T> span)
        where T : IEquatable<T>
    {
        /// <summary>
        ///     Returns the index of the n-th occurrence of a value in a <see cref="Span{T}" />.
        /// </summary>
        /// <returns>The index of the n-th occurrence of the value in the <see cref="Span{T}" />. If the value is not found, returns -1.</returns>
        public int NthIndexOf(T value, int n)
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
}
