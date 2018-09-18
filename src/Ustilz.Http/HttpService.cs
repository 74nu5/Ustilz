namespace Ustilz.Http
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
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
    [SuppressMessage("ReSharper", "StyleCop.SA1009", Justification = "Stylecop Issue with Tuple")]
    public sealed class HttpService
    {
        #region Champs

        /// <summary>The handler.</summary>
        private readonly HttpClientHandler handler;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="HttpService" />.Initializes a new instance of the <see cref="HttpService" /> class.
        /// </summary>
        public HttpService()
        {
            this.handler = new HttpClientHandler();
            this.handler.ServerCertificateCustomValidationCallback += (message, certificate2, arg3, arg4) => true;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The get http response async.</summary>
        /// <typeparam name="TResponse">Type de la réponse.</typeparam>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<(HttpStatusCode Code, string ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, TResponse Response)> GetHttpResponseAsync<TResponse>(
            string url,
            Dictionary<string, IEnumerable<string>> headers,
            string authentification)
        {
            var result =
                await new Func<string, Dictionary<string, IEnumerable<string>>, string, Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, TResponse)>>(
                    this.GetHttpResponseAsyncInternal<TResponse>).TestPerf(out var timestamp, url, headers, authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The get http response async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<(HttpStatusCode StatusCode, string ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string Response)> GetHttpResponseAsync(
            string url,
            Dictionary<string, IEnumerable<string>> headers,
            string authentification)
        {
            var result =
                await new Func<string, Dictionary<string, IEnumerable<string>>, string, Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, string)>>(
                    this.GetHttpResponseAsyncInternal).TestPerf(out var timestamp, url, headers, authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The get async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse.</typeparam>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<TResponse> GetStringAsync<TResponse>(string url, string authentification)
        {
            var result = await new Func<string, string, Task<TResponse>>(this.GetResponseAsyncInternal<TResponse>).TestPerf(out var timestamp, url, authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The get.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<string> GetStringAsync(string url, string authentification)
        {
            var result = await new Func<string, Dictionary<string, IEnumerable<string>>, string, Task<string>>(this.GetStringAsyncInternal).TestPerf(
                out var timestamp,
                url,
                null,
                authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The get async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<string> GetStringAsync(string url, Dictionary<string, IEnumerable<string>> headers, string authentification)
        {
            var result = await new Func<string, Dictionary<string, IEnumerable<string>>, string, Task<string>>(this.GetStringAsyncInternal).TestPerf(
                out var timestamp,
                url,
                headers,
                authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        /// <summary>The post.</summary>
        /// <param name="url">The url.</param>
        /// <param name="content">The http content.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse.</typeparam>
        /// <returns>The TResponse.</returns>
        public async Task<TResponse> PostAsync<TResponse>(string url, string content, string authentification)
        {
            var result = await new Func<string, Dictionary<string, IEnumerable<string>>, string, string, Task<TResponse>>(this.PostAsyncInternal<TResponse>).TestPerf(
                out var time,
                url,
                null,
                content,
                authentification);
            Debug.WriteLine($"GET {url} : {time} ms");
            return result;
        }

        /// <summary>The post async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="content">The content.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="string" />.</returns>
        public async Task<string> PostAsync(string url, string content, string authentification)
        {
            var result = await new Func<string, Dictionary<string, IEnumerable<string>>, string, string, Task<string>>(this.PostAsyncInternal).TestPerf(
                out var time,
                url,
                null,
                content,
                authentification);
            Debug.WriteLine($"GET {url} : {time} ms");
            return result;
        }

        /// <summary>The post async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="content">The content.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<string> PostAsync(string url, Dictionary<string, IEnumerable<string>> headers, string content, string authentification)
        {
            var result = await new Func<string, Dictionary<string, IEnumerable<string>>, string, string, Task<string>>(this.PostAsyncInternal).TestPerf(
                out var time,
                url,
                headers,
                content,
                authentification);
            Debug.WriteLine($"GET {url} : {time} ms");
            return result;
        }

        /// <summary>The post http response async.</summary>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="body">The body.</param>
        /// <param name="authentification">The authentification.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task<(HttpStatusCode StatusCode, string ResponsePhrase, Dictionary<string, IEnumerable<string>> Headers, string Response)> PostHttpResponseAsync(
            string url,
            Dictionary<string, IEnumerable<string>> headers,
            string body,
            string authentification)
        {
            var result =
                await new Func<string, Dictionary<string, IEnumerable<string>>, string, string, Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, string)>>(
                    this.PostHttpResponseAsyncInternal).TestPerf(out var timestamp, url, headers, body, authentification);
            Debug.WriteLine($"GET {url} : {timestamp} ms");
            return result;
        }

        #endregion

        #region Méthodes privées

        /// <summary>The get response async internal.</summary>
        /// <param name="url">The url.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse.</typeparam>
        /// <returns>The <see cref="Task" />.</returns>
        private async Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, TResponse)> GetHttpResponseAsyncInternal<TResponse>(
            string url,
            Dictionary<string, IEnumerable<string>> headers,
            string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return (response.StatusCode, response.ReasonPhrase, null, default);
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
        private async Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, string)> GetHttpResponseAsyncInternal(
            string url,
            Dictionary<string, IEnumerable<string>> headers,
            string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return (response.StatusCode, response.ReasonPhrase, null, null);
                }

                var headersResponse = response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value);
                return (response.StatusCode, response.ReasonPhrase, headersResponse, await response.Content.ReadAsStringAsync());
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
        private async Task<TResponse> GetResponseAsyncInternal<TResponse>(string url, string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);

            try
            {
                var response = await client.GetStringAsync(url);
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
        private async Task<string> GetStringAsyncInternal(string url, Dictionary<string, IEnumerable<string>> headers, string authentification)
        {
            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);
            client.SetHeaders(headers);

            try
            {
                return await client.GetStringAsync(url);
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
        private async Task<string> PostAsyncInternal(string url, Dictionary<string, IEnumerable<string>> headers, string body, string authentication)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var client = new HttpClient(this.handler);

            var content = new StringContent(body);
            client.SetAuthentication(authentication);
            client.SetHeaders(headers);

            try
            {
                var responseMessage = await client.PostAsync(url, content);
                return await responseMessage.Content.ReadAsStringAsync();
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
        private async Task<TResponse> PostAsyncInternal<TResponse>(string url, Dictionary<string, IEnumerable<string>> headers, string content, string authentification)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var json = new StringContent(content);

            var client = new HttpClient(this.handler);

            client.SetAuthentication(authentification);

            try
            {
                var response = await client.PostAsync(url, json);
                return response.Content.ToString().FromJson<TResponse>();
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
        private async Task<(HttpStatusCode, string, Dictionary<string, IEnumerable<string>>, string)> PostHttpResponseAsyncInternal(
            string url,
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
                var response = await client.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    return (response.StatusCode, response.ReasonPhrase, null, null);
                }

                var headersResponse = response.Headers.ToDictionary(pair => pair.Key, pair => pair.Value);
                return (response.StatusCode, response.ReasonPhrase, headersResponse, await response.Content.ReadAsStringAsync());
            }
            catch (WebException ex)
            {
                throw ex.ProcessWebException();
            }
        }

        #endregion
    }
}
