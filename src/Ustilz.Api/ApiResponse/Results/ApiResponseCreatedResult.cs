namespace Ustilz.Api.ApiResponse.Results;

using System.Net;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Http;

using Ustilz.Api.ApiResponse.Body;

/// <summary>
///     Class which represent an api response result.
/// </summary>
/// <typeparam name="TResult">Type of result.</typeparam>
[PublicAPI]
public class ApiResponseCreatedResult<TResult> : ApiResponseResult<TResult>
{
    private readonly Uri location;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    /// <param name="location">The rul of created resource.</param>
    /// <param name="result">The result body.</param>
    public ApiResponseCreatedResult(ApiRequestHeaders headers, Uri location, ApiResponseBody<TResult>? result = null)
        : base(headers, HttpStatusCode.Created, result)
        => this.location = location;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    /// <param name="location">The rul of created resource.</param>
    /// <param name="result">The result body.</param>
    public ApiResponseCreatedResult(ApiRequestHeaders headers, string location, ApiResponseBody<TResult>? result = null)
        : base(headers, HttpStatusCode.Created, result)
        => this.location = new(location, UriKind.RelativeOrAbsolute);

    /// <summary>
    ///     Write an HTTP response reflecting the result and set headers with <see cref="ApiRequestHeaders" />.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> for the current request.</param>
    /// <returns>A task that represents the asynchronous execute operation.</returns>
    public override Task ExecuteAsync(HttpContext httpContext)
    {
        httpContext.Response.Headers.Location = this.location.ToString();
        return base.ExecuteAsync(httpContext);
    }
}
