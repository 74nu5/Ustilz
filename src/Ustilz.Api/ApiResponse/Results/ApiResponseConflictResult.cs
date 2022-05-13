namespace Ustilz.Api.ApiResponse.Results;

using System.Net;

using JetBrains.Annotations;

using Ustilz.Api.ApiResponse;

/// <summary>
///     Class which represent an api response result.
/// </summary>
[PublicAPI]
public class ApiResponseConflictResult<TResult> : ApiResponseResult<TResult>
{
    private readonly ApiRequestHeaders headers;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    /// <param name="result">The conflicted result.</param>
    public ApiResponseConflictResult(ApiRequestHeaders headers, ApiResponseBody<TResult>? result)
        : base(headers, HttpStatusCode.Conflict, result)
        => this.headers = headers;
}
