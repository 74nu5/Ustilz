namespace Ustilz.Api.ApiResponse.Results;

using System.Net;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Http;

using Ustilz.Api.ApiResponse.Body;
using Ustilz.Models;

/// <summary>
///     Class which represent an api response result.
/// </summary>
/// <typeparam name="TResult">Type of result.</typeparam>
[PublicAPI]
public class ApiResponseResult<TResult> : IResult
{
    private readonly ApiRequestHeaders headers;

    private readonly HttpStatusCode? statusCode;

    private readonly ApiResponseBody<TResult>? result;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    /// <param name="statusCode">The result status code.</param>
    /// <param name="result">The result body.</param>
    public ApiResponseResult(ApiRequestHeaders headers, HttpStatusCode? statusCode = HttpStatusCode.OK, ApiResponseBody<TResult>? result = null)
    {
        this.headers = headers;
        this.statusCode = statusCode;
        this.result = result;
    }

    /// <summary>
    ///     Write an HTTP response reflecting the result and set headers with <see cref="ServiceMonitoringDefinition" />.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> for the current request.</param>
    /// <returns>A task that represents the asynchronous execute operation.</returns>
    public virtual Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.StatusCode = (int)(this.statusCode ?? HttpStatusCode.OK);

        httpContext.Response.Headers.Add(ServiceMonitoringDefinition.CorrelationIdKey, this.headers.CorrelationId.ToString());
        httpContext.Response.Headers.Add(ServiceMonitoringDefinition.FunctionalIdKey, this.headers.FunctionalId);
        httpContext.Response.Headers.Add(ServiceMonitoringDefinition.TechnicalIdKey, this.headers.TechnicalId.ToString());

        return this.result is null ? Task.CompletedTask : httpContext.Response.WriteAsJsonAsync(this.result);
    }
}
