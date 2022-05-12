namespace Ustilz.Models;
/// <summary>
///     Record which represent a return.
/// </summary>
public record ServiceResult(bool Success, params string[] ErrorMessage) : ServiceResult<object>(Success, null, ErrorMessage);
