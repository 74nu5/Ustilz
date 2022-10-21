namespace Ustilz.Api.ApiResponse;

using System;
using System.Collections.Generic;

using JetBrains.Annotations;

/// <summary>
///     Record which represent an api response body.
/// </summary>
/// <typeparam name="TResponse">The response type.</typeparam>
/// <param name="Success">A flag indicating whether the request succeed.</param>
/// <param name="Response">The response.</param>
/// <param name="ResponseError">The api response error.</param>
[PublicAPI]
public record ApiResponseBody<TResponse>(ApiResponseResultState Success, TResponse? Response, params ApiResponseError[] ResponseError)
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseBody{TResponse}" /> class.
    /// </summary>
    public ApiResponseBody()
        : this(ApiResponseResultState.Error, default, Array.Empty<ApiResponseError>())
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseBody{TResponse}" /> class.
    /// </summary>
    /// <param name="responseError">The <see cref="ApiResponseError" />.</param>
    public ApiResponseBody(List<ApiResponseError>? responseError)
        : this(ApiResponseResultState.Error, default, responseError?.ToArray() ?? Array.Empty<ApiResponseError>())
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseBody{TResponse}" /> class.
    /// </summary>
    /// <param name="responseError">The <see cref="ApiResponseError" />.</param>
    public ApiResponseBody(params ApiResponseError[] responseError)
        : this(ApiResponseResultState.Error, default, responseError)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseBody{TResponse}" /> class.
    /// </summary>
    /// <param name="resultState">The result state.</param>
    /// <param name="responseError">The <see cref="ApiResponseError" />.</param>
    public ApiResponseBody(ApiResponseResultState resultState, params ApiResponseError[] responseError)
        : this(resultState, default, responseError)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ApiResponseBody{TResponse}" /> class.
    /// </summary>
    /// <param name="response">The api response.</param>
    public ApiResponseBody(TResponse? response)
        : this(ApiResponseResultState.Success, response)
    {
    }
}
