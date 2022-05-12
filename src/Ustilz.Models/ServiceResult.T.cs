namespace Ustilz.Models;

/// <summary>
///     Record which represent a return.
/// </summary>
/// <typeparam name="TResult">The result type.</typeparam>
/// <param name="Success">A boolean indicating whether is success.</param>
/// <param name="Result">The result.</param>
/// <param name="ErrorMessage">The error message.</param>
public record ServiceResult<TResult>(bool Success, TResult? Result, params string[] ErrorMessage)
{
    /// <summary>
    ///     Method which retrieve all errors messages with comma as separator.
    /// </summary>
    /// <returns>Returns all errors messages with comma as separator.</returns>
    public string GetFormattedMessages() => string.Join(", ", this.ErrorMessage);
}
