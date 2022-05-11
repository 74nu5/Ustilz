namespace Ustilz.Http;

using System.Net;
using System.Net.Http.Headers;
using System.Text;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Http;

/// <summary>The http client extensions.</summary>
[PublicAPI]
public static class HttpExtensions
{
    /// <summary>Retrieves the raw body as a byte array from the Request.Body stream.</summary>
    /// <param name="request">The request.</param>
    /// <returns>The <see cref="Task" />.</returns>
    /// <exception cref="ArgumentNullException">Destination is null.</exception>
    /// <exception cref="ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
    /// <exception cref="NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Capacity is negative.</exception>
    public static async Task<byte[]> GetRawBodyBytesAsync(this HttpRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        await using var ms = new MemoryStream(2048);
        await request.Body.CopyToAsync(ms).ConfigureAwait(false);
        return ms.ToArray();
    }

    /// <summary>Retrieve the raw body as a string from the Request.Body stream.</summary>
    /// <param name="request">Request instance to apply to.</param>
    /// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
    /// <returns>The <see cref="Task" />.</returns>
    /// <exception cref="ArgumentException">Stream does not support reading.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="request" /> is <see langword="null" />.</exception>
    /// <exception cref="InvalidOperationException">The reader is currently in use by a previous read operation.</exception>
    /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
    /// <exception cref="ArgumentOutOfRangeException">The number of characters is larger than <see cref="int.MaxValue"></see>.</exception>
    public static Task<string> GetRawBodyStringAsync(this HttpRequest request, Encoding? encoding = null)
    {
        ArgumentNullException.ThrowIfNull(request);

        encoding ??= Encoding.UTF8;
        using var reader = new StreamReader(request.Body, encoding);
        return reader.ReadToEndAsync();
    }

    /// <summary>The process web exception.</summary>
    /// <param name="exception">The exception.</param>
    /// <returns>The <see cref="System.Exception" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception" /> is <see langword="null" />.</exception>
    /// <exception cref="NotSupportedException">Any attempt is made to access the method, when the method is not overridden in a descendant class.</exception>
    /// <exception cref="WebException">Throw web exeption when response stream is null.</exception>
    /// <exception cref="ArgumentException">Stream does not support reading.</exception>
    /// <exception cref="OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
    /// <exception cref="IOException">An I/O error occurs.</exception>
    public static WebException ProcessWebException(this WebException exception)
    {
        ArgumentNullException.ThrowIfNull(exception);

        var errorResponse = exception.Response;

        using var responseStream = errorResponse?.GetResponseStream();
        if (responseStream == null)
        {
            throw exception;
        }

        var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));

        var errorText = reader.ReadToEnd();

        throw new WebException(errorText);
    }

    /// <summary>The set authentication.</summary>
    /// <param name="client">The client.</param>
    /// <param name="authentication">The authentication.</param>
    /// <exception cref="ArgumentNullException"><paramref name="client" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="authentication" /> is <see langword="null" />.</exception>
    /// <exception cref="FormatException">Inputis not valid authentication header value information.</exception>
    public static void SetAuthentication(this HttpClient client, string authentication)
    {
        ArgumentNullException.ThrowIfNull(authentication);
        ArgumentNullException.ThrowIfNull(client);

        if (!string.IsNullOrEmpty(authentication))
        {
            client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(authentication);
        }
    }

    /// <summary>The set headers.</summary>
    /// <param name="client">The client.</param>
    /// <param name="headers">The headers.</param>
    /// <exception cref="ArgumentNullException"><paramref name="client" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="headers" /> is <see langword="null" />.</exception>
    public static void SetHeaders(this HttpClient client, Dictionary<string, IEnumerable<string>> headers)
    {
        ArgumentNullException.ThrowIfNull(headers);
        ArgumentNullException.ThrowIfNull(client);

        foreach (var (key, value) in headers)
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation(key, value);
        }
    }

    /// <summary>The set headers.</summary>
    /// <param name="response">The response.</param>
    /// <param name="headers">The headers.</param>
    /// <exception cref="ArgumentNullException"><paramref name="response" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="headers" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException">The source or predicate is null.</exception>
    /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="IDictionary{TKey,TValue}"></see>.</exception>
    /// <exception cref="NotSupportedException">The <see cref="IDictionary{TKey,TValue}"></see> is read-only.</exception>
    public static void SetHeaders(this HttpResponse response, Dictionary<string, IEnumerable<string>> headers)
    {
        ArgumentNullException.ThrowIfNull(headers);
        ArgumentNullException.ThrowIfNull(response);

        foreach (var (key, value) in headers.Where(pair => pair.Key != "Transfer-Encoding"))
        {
            response.Headers.Add(key, value.ToArray());
        }
    }
}
