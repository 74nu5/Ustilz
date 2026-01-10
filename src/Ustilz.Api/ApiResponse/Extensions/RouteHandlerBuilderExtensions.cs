namespace Ustilz.Api.ApiResponse.Extensions;

using System.Net;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using Ustilz.Api.ApiResponse;

/// <summary>
///     Extension class for <see cref="RouteHandlerBuilder" /> type.
/// </summary>
public static class RouteHandlerBuilderExtensions
{
    extension(RouteHandlerBuilder routeHandlerBuilder)
    {
        /// <summary>
        ///     Method which add metadata : Produces <see cref="ApiResponseBody{TResponse}" />.
        /// </summary>
        /// <typeparam name="TResult">Response type.</typeparam>
        /// <returns>Return the route builder.</returns>
        public RouteHandlerBuilder ProducesApiResponse<TResult>()
            => routeHandlerBuilder.Produces<ApiResponseBody<TResult>>();
    }

    extension(RouteHandlerBuilder routeHandlerBuilder)
    {
        /// <summary>
        ///     Method which add metadata : Produces <see cref="ApiResponseBody{TResponse}" />.
        /// </summary>
        /// <returns>Return the route builder.</returns>
        public RouteHandlerBuilder ProducesApiResponse<TResult>(HttpStatusCode statusCode)
            => routeHandlerBuilder.Produces<ApiResponseBody<TResult>>((int)statusCode);
    }
}
