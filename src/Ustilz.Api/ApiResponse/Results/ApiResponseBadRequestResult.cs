namespace Ustilz.Api.ApiResponse.Results;

using System.Net;

using JetBrains.Annotations;

/// <summary>
///     Class which represent an api response result.
/// </summary>
[PublicAPI]
public class ApiResponseBadRequestResult : ApiResponseResult<object>
{
    private readonly ApiRequestHeaders headers;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    /// <param name="errors">The bad request errors.</param>
    public ApiResponseBadRequestResult(ApiRequestHeaders headers, params ApiResponseError[] errors)
        : base(headers, HttpStatusCode.BadRequest, errors.Any() ? new(errors) : null)
        => this.headers = headers;
}
