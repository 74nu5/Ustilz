namespace Ustilz.Api.ApiResponse;

/// <summary>
///     Represents all result states for an <seealso cref="ApiResponse{TResponse}" />
/// </summary>
public enum ApiResponseResultState
{
    /// <summary>
    ///     When every thing is ok.
    /// </summary>
    Success = 0,

    /// <summary>
    ///     When some calls are in error.
    /// </summary>
    Incomplete = 1,

    /// <summary>
    ///     When all calls are in error.
    /// </summary>
    Error = 2,

    /// <summary>
    ///     When some calls returns unauthorized code.
    /// </summary>
    Unauthorized = 3,

    /// <summary>
    ///     When some calls returns forbidden code.
    /// </summary>
    Forbidden = 4,

    /// <summary>
    ///     When some calls returns bad request code.
    /// </summary>
    BadRequest = 5,

    /// <summary>
    ///     When some calls returns not found code.
    /// </summary>
    NotFound = 6,

    /// <summary>
    ///     When some calls returns conflict code.
    /// </summary>
    Conflict = 7
}
