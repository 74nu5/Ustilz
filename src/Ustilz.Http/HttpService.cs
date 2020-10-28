namespace Ustilz.Http
{
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
    public sealed class HttpService : IDisposable
    {
        /// <summary>The handler.</summary>
        private readonly HttpClientHandler handler;

        /// <summary>Initialise une nouvelle instance de la classe <see cref="HttpService" />.Initializes a new instance of the <see cref="HttpService" /> class.</summary>
        public HttpService()
        {
            this.handler = new HttpClientHandler();
            this.handler.ServerCertificateCustomValidationCallback += (message, certificate2, arg3, arg4) => true;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
            => this.handler.Dispose();

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
            [NotNull] Uri url,
            [NotNull] Dictionary<string, IEnumerable<string>> headers,
            [NotNull] string authentification)
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

            if (authentification == null)
            {
                throw new ArgumentNullException(nameof(authentification));
            }

            var result =
                await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, TResponse?)>>(
                        this.GetHttpResponseAsyncInternalAsync<TResponse>).TestPerf(out var timestamp, url, headers, authentification)
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
            [NotNull] Uri url,
            [NotNull] Dictionary<string, IEnumerable<string>> headers,
            [NotNull] string authentification)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            if (headers == null)
            {
                throw new ArgumentNullException(nameof(headers));
            }

            if (authentification == null)
            {
                throw new ArgumentNullException(nameof(authentification));
            }

            var result =
                await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, string?)>>(
                        this.GetHttpResponseAsyncInternalAsync).TestPerf(out var timestamp, url, headers, authentification)
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
        public async Task<TResponse?> GetStringAsync<TResponse>([NotNull] Uri url, [NotNull] string authentification)
            where TResponse : class
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            if (authentification == null)
            {
                throw new ArgumentNullException(nameof(authentification));
            }

            var result = await new Func<Uri, string, Task<TResponse?>>(this.GetResponseAsyncInternalAsync<TResponse>)
                               .TestPerf(out var timestamp, url, authentification)
                               .ConfigureAwait(false);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The get.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<string> GetStringAsync(Uri url, string authentification)
        {
            var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, Task<string>>(this.GetStringAsyncInternalAsync).TestPerf(
                                 out var timestamp,
                                 url,
                                 new Dictionary<string,
                                     IEnumerable<string>>(),
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
        public async Task<string> GetStringAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string authentification)
        {
            var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, Task<string>>(this.GetStringAsyncInternalAsync).TestPerf(
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
        public async Task<TResponse?> PostAsync<TResponse>(Uri url, string content, string authentification)
            where TResponse : class
        {
            var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string, Task<TResponse?>>(this.PostAsyncInternalAsync<TResponse>).TestPerf(
                                 out var time,
                                 url,
                                 new Dictionary<
                                     string,
                                     IEnumerable<
                                         string>
                                 >(),
                                 content,
                                 authentification)
                             .ConfigureAwait(false);
            Debug.WriteLine($"GET {url} : {time} ms");
            return result;
        }

        /// <summary>The post async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="content">The content.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="string" />.</returns>
        public async Task<string> PostAsync(Uri url, string content, string authentification)
        {
            var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string, Task<string>>(this.PostAsyncInternalAsync).TestPerf(
                                 out var time,
                                 url,
                                 new Dictionary<string,
                                     IEnumerable<string>>(),
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
        public async Task<string> PostAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string content, string authentification)
        {
            var result = await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string, Task<string>>(this.PostAsyncInternalAsync).TestPerf(
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
            string authentification)
        {
            var result =
                await new Func<Uri, Dictionary<string, IEnumerable<string>>, string, string, Task<(HttpStatusCode, string?, Dictionary<string, IEnumerable<string>>, string?)>>(
                        this.PostHttpResponseAsyncInternalAsync).TestPerf(out var timestamp, url, headers, body, authentification)
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
                string authentification)
            where TResponse : class, new()
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return (response.StatusCode, response.ReasonPhrase, new Dictionary<string, IEnumerable<string>>(), new TResponse());
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
                string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return (response.StatusCode, response.ReasonPhrase, new Dictionary<string, IEnumerable<string>>(), string.Empty);
                }

                var headersResponse = response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value);
                return (response.StatusCode, response.ReasonPhrase, headersResponse, await response.Content.ReadAsStringAsync().ConfigureAwait(false));
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
        private async Task<TResponse?> GetResponseAsyncInternalAsync<TResponse>(Uri url, string authentification)
            where TResponse : class
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);

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
        private async Task<string> GetStringAsyncInternalAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
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
        private async Task<string> PostAsyncInternalAsync(Uri url, Dictionary<string, IEnumerable<string>> headers, string body, string authentication)
        {
            var stopWatch = Stopwatch.StartNew();
            var client = new HttpClient(this.handler);

            var content = new StringContent(body);
            client.SetAuthentication(authentication);
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
        private async Task<TResponse?> PostAsyncInternalAsync<TResponse>(Uri url, Dictionary<string, IEnumerable<string>> headers, string content, string authentification)
            where TResponse : class
        {
            var stopWatch = Stopwatch.StartNew();

            var json = new StringContent(content);
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);

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
                string authentification)
        {
            var client = new HttpClient(this.handler);
            var content = new StringContent(body);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                var response = await client.PostAsync(url, content).ConfigureAwait(false);
                return !response.IsSuccessStatusCode
                           ? (response.StatusCode, response.ReasonPhrase, new Dictionary<string, IEnumerable<string>>(), string.Empty)
                           : (response.StatusCode, response.ReasonPhrase, response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value),
                                 await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            }
            catch (WebException ex)
            {
                throw ex.ProcessWebException();
            }
        }
    }
}
