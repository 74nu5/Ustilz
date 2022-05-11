namespace Ustilz.Data.AccessLayer.Queries.Pageable;

using JetBrains.Annotations;

/// <summary>
///     Class which represent a pageable result.
/// </summary>
/// <typeparam name="TItem">Type of result elements.</typeparam>
/// <param name="Items">Gets the list of elements.</param>
/// <param name="TotalElements">Gets the total elements.</param>
[PublicAPI]
public record PageableResult<TItem>(IEnumerable<TItem>? Items, int TotalElements);
