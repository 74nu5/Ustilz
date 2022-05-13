namespace Ustilz.Api.ApiResponse.Extensions;

using System.Net;

using Microsoft.AspNetCore.Http;

using Ustilz.Api.ApiResponse.Results;

public static class ResultsExtensions
{
    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <typeparam name="TResult">Type of result.</typeparam>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="result">The result.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult Ok<TResult>(this IResultExtensions resultExtensions, ApiRequestHeaders headers, TResult result)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseResult<TResult>(headers, HttpStatusCode.OK, new(result));
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult NotFound(this IResultExtensions resultExtensions, ApiRequestHeaders headers)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseNotFoundResult(headers);
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="errors">The bad request errors.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult BadRequest(this IResultExtensions resultExtensions, ApiRequestHeaders headers, params ApiResponseError[] errors)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseBadRequestResult(headers, errors);
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="result">The conflicted result.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult Conflict<TResult>(this IResultExtensions resultExtensions, ApiRequestHeaders headers, TResult? result = default)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseConflictResult<TResult>(headers, result == null ? null : new(result));
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult NoContent(this IResultExtensions resultExtensions, ApiRequestHeaders headers)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseNoContentResult(headers);
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <typeparam name="TResult">Type of result.</typeparam>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="location">The resources created uri.</param>
    /// <param name="result">The result.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult Created<TResult>(this IResultExtensions resultExtensions, ApiRequestHeaders headers, Uri location, TResult? result = default)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseCreatedResult<TResult>(headers, location, result == null ? null : new(result));
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <typeparam name="TResult">Type of result.</typeparam>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="location">The resources created uri.</param>
    /// <param name="apiResponseBody">The result.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult Created<TResult>(this IResultExtensions resultExtensions, ApiRequestHeaders headers, string location, TResult? result = default)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));
        return new ApiResponseCreatedResult<TResult>(headers, location, result == null ? null : new(result));
    }

    /// <summary>
    ///     Method which returns a new api response result.
    /// </summary>
    /// <param name="resultExtensions">The result extensions.</param>
    /// <param name="headers">The api headers.</param>
    /// <param name="statusCode">The result status code.</param>
    /// <param name="result">The result.</param>
    /// <param name="errors">The errors.</param>
    /// <returns>Returns a new api response result.</returns>
    public static IResult StatusCode<TResult>(
        this IResultExtensions resultExtensions,
        ApiRequestHeaders headers,
        HttpStatusCode statusCode,
        TResult result,
        params ApiResponseError[] errors)
    {
        ArgumentNullException.ThrowIfNull(resultExtensions, nameof(resultExtensions));

        return (result, errors) switch
               {
                   (null, null) => new(headers, statusCode),
                   (null, var _) => new(headers, statusCode, new(errors)),
                   (var _, null) => new ApiResponseResult<TResult>(headers, statusCode, new(result)),
                   var _ => throw new ArgumentOutOfRangeException()
               };
    }
}
