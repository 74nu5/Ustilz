namespace Ustilz.Api.ApiResponse;

using JetBrains.Annotations;

/// <summary>
///     Record which represent a api error.
/// </summary>
/// <param name="ErrorCode">The error code.</param>
/// <param name="ErrorMessage">The error message.</param>
[PublicAPI]
public record ApiResponseError(int ErrorCode, string ErrorMessage)
{
    /// <summary>
    ///     Represents a empty error.
    /// </summary>
    public static readonly ApiResponseError Empty = new(-1, string.Empty);

    /// <summary>
    ///     Represents a not implemented error.
    /// </summary>
    public static readonly ApiResponseError NotImplemented = new(9999, "Not implemented");

    /// <summary>
    ///     Represents a not found error.
    /// </summary>
    public static readonly ApiResponseError NotFound = new(4004, "Resource not found");

    /// <summary>
    /// Implict operator which convert a string to a <see cref="ApiResponseError" />.
    /// </summary>
    /// <param name="error">The error.</param>
    public static implicit operator ApiResponseError(string error)
        => new(99999, error);
}
