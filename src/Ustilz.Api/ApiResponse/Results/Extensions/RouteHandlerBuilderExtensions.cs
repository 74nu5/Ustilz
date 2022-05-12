namespace Ustilz.Api.ApiResponse.Results.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Ustilz.Api.ApiResponse.Body;

/// <summary>
///     Extension class for <see cref="RouteHandlerBuilder" /> type.
/// </summary>
public static class RouteHandlerBuilderExtensions
{
    /// <summary>
    ///     Method which add metadata : Produces <see cref="ApiResponseBody{TResponse}" />.
    /// </summary>
    /// <typeparam name="TResult">Response type.</typeparam>
    /// <param name="routeHandlerBuilder">The route builder.</param>
    /// <returns>Return the route builder.</returns>
    public static RouteHandlerBuilder ProducesApiResponse<TResult>(this RouteHandlerBuilder routeHandlerBuilder)
        => routeHandlerBuilder.Produces<ApiResponseBody<TResult>>();

    /// <summary>
    ///     Method which add metadata : Produces <see cref="ApiResponseBody{TResponse}" />.
    /// </summary>
    /// <param name="routeHandlerBuilder">The route builder.</param>
    /// <param name="statusCode">The status code.</param>
    /// <returns>Return the route builder.</returns>
    public static RouteHandlerBuilder ProducesApiResponse<TResult>(this RouteHandlerBuilder routeHandlerBuilder, HttpStatusCode statusCode)
        => routeHandlerBuilder.Produces<ApiResponseBody<TResult>>((int)statusCode);
}
