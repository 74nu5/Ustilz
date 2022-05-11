namespace Ustilz.Http;

#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using JetBrains.Annotations;

using Ustilz.Extensions;
using Ustilz.Json;

#endregion

/// <summary>The http service.</summary>
[PublicAPI]
public sealed class HttpService
{
    internal const string HttpClientName = "ustilz-http-client";

    private readonly IHttpClientFactory clientFactory;

    /// <summary>Initialise une nouvelle instance de la classe <see cref="HttpService" />.Initializes a new instance of the <see cref="HttpService" /> class.</summary>
    public HttpService(IHttpClientFactory clientFactory)
        => this.clientFactory = clientFactory;

    /// <summary>The get http response async.</summary>
    /// <typeparam name="TResponse">Type de la réponse.</typeparam>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="url" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="headers" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="authentification" /> is <see langword="null" />.</exception>
    public async Task<(HttpStatusCode Code, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, TResponse? Response)> GetHttpResponseAsync<TResponse>(
        Uri url,
        Dictionary<string, IEnumerable<string>> headers,
        string? authentification)
        where TResponse : class, new()
    {
        if (url == null)
        {
            throw new ArgumentNullException(nameof(url));
        }

        if (headers == null)
        {
            throw new ArgumentNullException(nameof(headers));
        }

        var result =
            await new Func<Uri, Dictionary<string, IEnumerable<string>>, string?, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, TResponse?)>>(
                                                                                                                                                                        this
                                                                                                                                                                           .GetHttpResponseAsyncInternalAsync
                                                                                                                                                                            <TResponse>)
                 .TestPerf(out var timestamp, url, headers, authentification)
                 .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The get http response async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <exception cref="ArgumentNullException"><paramref name="url" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="headers" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="authentification" /> is <see langword="null" />.</exception>
    /// <returns>The <see cref="Task" />.</returns>
    public async Task<(HttpStatusCode StatusCode, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string? Response)> GetHttpResponseAsync(
        Uri url,
        Dictionary<string, IEnumerable<string>> headers,
        string? authentification)
    {
        if (url == null)
        {
            throw new ArgumentNullException(nameof(url));
        }

        if (headers == null)
        {
            throw new ArgumentNullException(nameof(headers));
        }

        var result =
            await new Func<Uri, Dictionary<string, IEnumerable<string>>, string?, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, string?)>>(
                                                                                                                                                                     this
                                                                                                                                                                        .GetHttpResponseAsyncInternalAsync)
                 .TestPerf(out var timestamp, url, headers, authentification)
                 .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The get async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="authentification">The authentification.</param>
    /// <typeparam name="TResponse">Type de la réponse.</typeparam>
    /// <returns>The <see cref="Task" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="url" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="authentification" /> is <see langword="null" />.</exception>
    public async Task<TResponse?> GetStringAsync<TResponse>(Uri url, string? authentification)
        where TResponse : class
    {
        if (url == null)
        {
            throw new ArgumentNullException(nameof(url));
        }

        var result = await new Func<Uri, string?, Task<TResponse?>>(this.GetResponseAsyncInternalAsync<TResponse>)
                          .TestPerf(out var timestamp, url, authentification)
                          .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The get.</summary>
    /// <param name="url">The url.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    public async Task<string> GetStringAsync(Uri url, string? authentification)
    {
        var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string?, Task<string>>(this.GetStringAsyncInternalAsync).TestPerf(
                                                                                                                                                    out var timestamp,
                                                                                                                                                    url,
                                                                                                                                                    new (),
                                                                                                                                                    authentification)
                                                                                                                                          .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The get async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    public async Task<string> GetStringAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string? authentification)
    {
        var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string?, Task<string>>(this.GetStringAsyncInternalAsync).TestPerf(
                                                                                                                                                    out var timestamp,
                                                                                                                                                    url,
                                                                                                                                                    headers,
                                                                                                                                                    authentification)
                                                                                                                                          .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The post.</summary>
    /// <param name="url">The url.</param>
    /// <param name="content">The http content.</param>
    /// <param name="authentification">The authentification.</param>
    /// <typeparam name="TResponse">Type de la réponse.</typeparam>
    /// <returns>The TResponse.</returns>
    public async Task<TResponse?> PostAsync<TResponse>(Uri url, string content, string? authentification)
        where TResponse : class
    {
        var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string?, Task<TResponse?>>(this.PostAsyncInternalAsync<TResponse>).TestPerf(
                                                                                                                                                                      out
                                                                                                                                                                      var time,
                                                                                                                                                                      url,
                                                                                                                                                                      new (),
                                                                                                                                                                      content,
                                                                                                                                                                      authentification)
                                                                                                                                                            .ConfigureAwait(
                                                                                                                                                                            false);
        Debug.WriteLine($"GET {url} : {time} ms");
        return result;
    }

    /// <summary>The post async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="content">The content.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="string" />.</returns>
    public async Task<string> PostAsync(Uri url, string content, string? authentification)
    {
        var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string?, Task<string>>(this.PostAsyncInternalAsync).TestPerf(
                                                                                                                                                       out var time,
                                                                                                                                                       url,
                                                                                                                                                       new (),
                                                                                                                                                       content,
                                                                                                                                                       authentification)
                                                                                                                                             .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {time} ms");
        return result;
    }

    /// <summary>The post async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="content">The content.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    public async Task<string> PostAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string content, string? authentification)
    {
        var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string?, Task<string>>(this.PostAsyncInternalAsync).TestPerf(
                                                                                                                                                       out var time,
                                                                                                                                                       url,
                                                                                                                                                       headers,
                                                                                                                                                       content,
                                                                                                                                                       authentification)
                                                                                                                                             .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {time} ms");
        return result;
    }

    /// <summary>The post http response async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="body">The body.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    public async Task<(HttpStatusCode StatusCode, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string? Response)> PostHttpResponseAsync(
        Uri url,
        Dictionary<string, IEnumerable<string>> headers,
        string body,
        string? authentification)
    {
        var result =
            await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string?, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, string?)>>(
                                                                                                                                                                             this
                                                                                                                                                                                .PostHttpResponseAsyncInternalAsync)
                 .TestPerf(out var timestamp, url, headers, body, authentification)
                 .ConfigureAwait(false);
        Debug.WriteLine($"GET {url} : {timestamp} ms");
        return result;
    }

    /// <summary>The get response async internal.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <typeparam name="TResponse">Type de la réponse.</typeparam>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<(HttpStatusCode StatusCode, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, TResponse? Response)>
        GetHttpResponseAsyncInternalAsync<TResponse>(
            Uri url,
            Dictionary<string, IEnumerable<string>> headers,
            string? authentification)
        where TResponse : class, new()
    {
        using var client = this.clientFactory.CreateClient(HttpClientName);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        client.SetHeaders(headers);

        try
        {
            var response = await client.GetAsync(url).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                return (response.StatusCode, response.ReasonPhrase, new (), new ());
            }

            var headersResponse = response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value);
            return (response.StatusCode, response.ReasonPhrase, headersResponse, response.Content.ReadAsStringAsync().Result.FromJson<TResponse>());
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
    }

    /// <summary>The get http response async internal.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<(HttpStatusCode StatusCode, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string? Response)>
        GetHttpResponseAsyncInternalAsync(
            Uri url,
            Dictionary<string, IEnumerable<string>> headers,
            string? authentification)
    {
        using var client = this.clientFactory.CreateClient(HttpClientName);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        client.SetHeaders(headers);

        try
        {
            var response = await client.GetAsync(url).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                return (response.StatusCode, response.ReasonPhrase, new (), string.Empty);
            }

            var headersResponse = response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value);
            //headersResponse = headersResponse.Concat(response.Content.Headers.ToDictionary(pair => pair.Key, pair => pair.Value)).ToDictionary(x => x.Key, x => x.Value);

            var contentStr = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return (response.StatusCode, response.ReasonPhrase, headersResponse, contentStr);
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
    }

    /// <summary>The get.</summary>
    /// <param name="url">The url.</param>
    /// <param name="authentification">The authentification.</param>
    /// <typeparam name="TResponse">Type de la réponse.</typeparam>
    /// <returns>The TResponse.</returns>
    private async Task<TResponse?> GetResponseAsyncInternalAsync<TResponse>(Uri url, string? authentification)
        where TResponse : class
    {
        using var client = this.clientFactory.CreateClient(HttpClientName);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        try
        {
            var response = await client.GetStringAsync(url).ConfigureAwait(false);
            return response.FromJson<TResponse>();
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
    }

    /// <summary>The get async internal.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<string> GetStringAsyncInternalAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string? authentification)
    {
        using var client = this.clientFactory.CreateClient(HttpClientName);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        client.SetHeaders(headers);

        try
        {
            return await client.GetStringAsync(url).ConfigureAwait(false);
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
    }

    /// <summary>The post async.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="body">The body.</param>
    /// <param name="authentication">The authentication.</param>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<string> PostAsyncInternalAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string body, string? authentication)
    {
        var stopWatch = Stopwatch.StartNew();
        using var client = this.clientFactory.CreateClient(HttpClientName);

        using var content = new StringContent(body);

        if (authentication is not null)
        {
            client.SetAuthentication(authentication);
        }

        client.SetHeaders(headers);

        try
        {
            var responseMessage = await client.PostAsync(url, content).ConfigureAwait(false);
            return await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
        finally
        {
            stopWatch.Stop();
            Debug.WriteLine($"POST {url} : {stopWatch.ElapsedMilliseconds} ms");
        }
    }

    /// <summary>The post async internal.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="content">The content.</param>
    /// <param name="authentification">The authentification.</param>
    /// <typeparam name="TResponse">Test de la réponse.</typeparam>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<TResponse?> PostAsyncInternalAsync<TResponse>(Uri url, Dictionary<string, IEnumerable<string>> headers, string content, string? authentification)
        where TResponse : class
    {
        var stopWatch = Stopwatch.StartNew();

        using var json = new StringContent(content);
        using var client = this.clientFactory.CreateClient(HttpClientName);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        try
        {
            var response = await client.PostAsync(url, json).ConfigureAwait(false);
            return response.Content.ToString()?.FromJson<TResponse>();
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
        finally
        {
            stopWatch.Stop();
            Debug.WriteLine($"POST {url} : {stopWatch.ElapsedMilliseconds} ms");
        }
    }

    /// <summary>The post http response async internal.</summary>
    /// <param name="url">The url.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="body">The body.</param>
    /// <param name="authentification">The authentification.</param>
    /// <returns>The <see cref="Task" />.</returns>
    private async Task<(HttpStatusCode StatusCode, string? ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string? Response)>
        PostHttpResponseAsyncInternalAsync(
            Uri url,
            Dictionary<string, IEnumerable<string>> headers,
            string body,
            string? authentification)
    {
        using var client = this.clientFactory.CreateClient(HttpClientName);
        using var content = new StringContent(body);

        if (authentification is not null)
        {
            client.SetAuthentication(authentification);
        }

        client.SetHeaders(headers);

        try
        {
            var response = await client.PostAsync(url, content).ConfigureAwait(false);
            return !response.IsSuccessStatusCode
                       ? (response.StatusCode, response.ReasonPhrase, new (), string.Empty)
                       : (response.StatusCode, response.ReasonPhrase, response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value),
                          await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
        catch (WebException ex)
        {
            throw ex.ProcessWebException();
        }
    }
}
