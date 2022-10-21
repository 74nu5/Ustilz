namespace Ustilz.Data.AccessLayer.Queries.Pageable;

using JetBrains.Annotations;

/// <summary>
///     Class which represent pageable query.
/// </summary>
/// <param name="PageSize">Gets or sets the page size.</param>
/// <param name="CurrentPage">Gets or sets the current page.</param>
[PublicAPI]
public record PageableQuery(int PageSize, int CurrentPage);
