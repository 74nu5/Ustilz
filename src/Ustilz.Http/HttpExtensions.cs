namespace Ustilz.Http
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    using JetBrains.Annotations;

    using Microsoft.AspNetCore.Http;

    #endregion

    /// <summary>The http client extensions.</summary>
    [PublicAPI]
    public static class HttpExtensions
    {
        #region Méthodes publiques

        /// <summary>Retrieves the raw body as a byte array from the Request.Body stream.</summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public static async Task<byte[]> GetRawBodyBytesAsync(this HttpRequest request)
        {
            using (var ms = new MemoryStream(2048))
            {
                await request.Body.CopyToAsync(ms);
                return ms.ToArray();
            }
        }

        /// <summary>Retrieve the raw body as a string from the Request.Body stream.</summary>
        /// <param name="request">Request instance to apply to.</param>
        /// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public static async Task<string> GetRawBodyStringAsync(this HttpRequest request, Encoding encoding = null)
        {
            using (var reader = new StreamReader(request.Body, encoding ?? Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

        /// <summary>The process web exception.</summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The <see cref="System.Exception" />.</returns>
        public static WebException ProcessWebException(this WebException exception)
        {
            var errorResponse = exception.Response;

            using (var responseStream = errorResponse.GetResponseStream())
            {
                if (responseStream == null)
                {
                    throw exception;
                }

                var reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));

                var errorText = reader.ReadToEnd();

                throw new WebException(errorText);
            }
        }

        /// <summary>The set authentication.</summary>
        /// <param name="client">The client.</param>
        /// <param name="authentication">The authentication.</param>
        public static void SetAuthentication(this HttpClient client, string authentication)
        {
            if (!string.IsNullOrEmpty(authentication))
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(authentication);
            }
        }

        /// <summary>The set headers.</summary>
        /// <param name="client">The client.</param>
        /// <param name="headers">The headers.</param>
        public static void SetHeaders(this HttpClient client, Dictionary<string, IEnumerable<string>> headers)
        {
            if (headers == null)
            {
                return;
            }

            foreach (var header in headers)
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            }
        }

        /// <summary>The set headers.</summary>
        /// <param name="response">The response.</param>
        /// <param name="headers">The headers.</param>
        public static void SetHeaders(this HttpResponse response, Dictionary<string, IEnumerable<string>> headers)
        {
            if (headers == null)
            {
                return;
            }

            foreach (var header in headers.Where(pair => pair.Key != "Transfer-Encoding"))
            {
                response.Headers.Add(header.Key, header.Value.ToArray());
            }
        }

        #endregion
    }
}
