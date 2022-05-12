namespace Ustilz.Api.ApiResponse;

using System.Net;

using Microsoft.AspNetCore.Http;

/// <summary>
///     Class which represent an api response result.
/// </summary>
/// <typeparam name="TResult">Type of result.</typeparam>
internal class ApiResponseResult<TResult> : IResult
{
    private readonly MonitoringIds monitoringIds;

    private readonly ApiResponseBody<TResult> result;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponseResult{TResult}"/> class.
    /// </summary>
    /// <param name="monitoringIds">The monitoring ids.</param>
    /// <param name="result">The result body.</param>
    public ApiResponseResult(MonitoringIds monitoringIds, ApiResponseBody<TResult> result)
    {
        this.monitoringIds = monitoringIds;
        this.result = result;
    }

    /// <summary>
    ///     Write an HTTP response reflecting the result and set headers with <see cref="MonitoringIds" />.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> for the current request.</param>
    /// <returns>A task that represents the asynchronous execute operation.</returns>
    public Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.StatusCode = this.result switch
        {
            ApiResponseBodyNotFound<TResult> => (int)HttpStatusCode.NotFound,
            not null => httpContext.Response.StatusCode,
            var _ => httpContext.Response.StatusCode
        };

        httpContext.Response.Headers.Add(MonitoringIds.CorrelationIdKey, this.monitoringIds.CorrelationId.ToString());
        httpContext.Response.Headers.Add(MonitoringIds.FunctionalIdKey, this.monitoringIds.FunctionalId);
        httpContext.Response.Headers.Add(MonitoringIds.TechnicalIdKey, this.monitoringIds.TechnicalId.ToString());

        return httpContext.Response.WriteAsJsonAsync(this.result);
    }
}
