namespace Ustilz.Data.Entities;

using Ustilz.Data.Interfaces;

/// <summary>
///     Base abstract definition of an object model.
///     Every objects must have a technical id, a creation date and a modification date.
/// </summary>
public abstract class ADataObject<TIdentity> : IDto<TIdentity>
    where TIdentity : IComparable<TIdentity>
{
    /// <summary>
    ///     Gets or sets the primary key.
    /// </summary>
    public TIdentity Id { get; set; } = default!;
}
