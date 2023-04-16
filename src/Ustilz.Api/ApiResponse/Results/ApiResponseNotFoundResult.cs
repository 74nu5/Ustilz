// Copyright (c) PlaceholderCompany. All rights reserved.

namespace Ustilz.Api.ApiResponse.Results;

using System.Net;

using JetBrains.Annotations;

/// <summary>
///     Class which represent an api response result.
/// </summary>
[PublicAPI]
public class ApiResponseNotFoundResult : ApiResponseResult<object>
{
    private readonly ApiRequestHeaders headers;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseResult{TResult}" /> class.
    /// </summary>
    /// <param name="headers">The monitoring ids.</param>
    public ApiResponseNotFoundResult(ApiRequestHeaders headers)
        : base(headers, HttpStatusCode.NotFound)
        => this.headers = headers;
}
