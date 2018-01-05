namespace Ustilz.Http
{
    #region Usings

    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;

    using JetBrains.Annotations;

    using Ustilz.Json;

    #endregion

    /// <summary>The http service.</summary>
    [PublicAPI]
    public sealed class HttpService
    {
        #region Méthodes publiques

        /// <summary>The delete.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse</typeparam>
        /// <returns>The <see cref="TResponse" />.</returns>
        public static TResponse Delete<TResponse>(string url, string authentification) => throw new NotImplementedException();

        /// <summary>The get.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse</typeparam>
        /// <returns>The <see cref="TResponse" />.</returns>
        public static TResponse Get<TResponse>(string url, string authentification)
        {
            var handler = new HttpClientHandler();

            handler.ServerCertificateCustomValidationCallback += (message, certificate2, arg3, arg4) => true;

            var client = new HttpClient(handler);

            if (!string.IsNullOrEmpty(authentification))
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(authentification);
            }

            try
            {
                var response = client.GetStringAsync(url);
                return response.Result.FromJson<TResponse>();
            }
            catch (WebException ex)
            {
                var errorResponse = ex.Response;

                using (var responseStream = errorResponse.GetResponseStream())
                {
                    if (responseStream == null)
                    {
                        throw;
                    }

                    var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));

                    var errorText = reader.ReadToEnd();

                    throw new Exception(errorText);
                }
            }
        }

        /// <summary>The post.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse</typeparam>
        /// <returns>The <see cref="TResponse" />.</returns>
        public static TResponse Post<TResponse>(string url, string authentification) => throw new NotImplementedException();

        /// <summary>The put.</summary>
        /// <param name="url">The url.</param>
        /// <param name="authentification">The authentification.</param>
        /// <typeparam name="TResponse">Type de la réponse</typeparam>
        /// <returns>The <see cref="TResponse" />.</returns>
        public static TResponse Put<TResponse>(string url, string authentification) => throw new NotImplementedException();

        #endregion
    }
}
