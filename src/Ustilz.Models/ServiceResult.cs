namespace Ustilz.Models;

using JetBrains.Annotations;

/// <summary>
///     Record which represent a return.
/// </summary>
[PublicAPI]
public record ServiceResult(bool Success, params string[] ErrorMessage) : ServiceResult<object>(Success, null, ErrorMessage);
