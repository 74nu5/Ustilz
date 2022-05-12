namespace Ustilz.Models;

using JetBrains.Annotations;

/// <summary>
///     Record which represent a return pageable.
/// </summary>
/// <typeparam name="TResult">The result type.</typeparam>
/// <param name="Success">A boolean indicating whether is success.</param>
/// <param name="PageableResult">The pageable result.</param>
/// <param name="ErrorMessage">The error message.</param>
[PublicAPI]
public record ServiceResultPageable<TResult>(bool Success, PageableResult<TResult>? PageableResult, string? ErrorMessage);
