namespace Ustilz.Data.Entities;

using Ustilz.Data.Interfaces;

/// <summary>
///     Base abstract definition of an object model.
///     Every objects must have a creation date and a modification date.
/// </summary>
public abstract class ATraceableDataObject<TIdentity> : ADataObject<TIdentity>, ITraceableDataObject
    where TIdentity : IComparable<TIdentity>
{
    /// <inheritdoc />
    public DateTime CreationDate { get; set; }

    /// <inheritdoc />
    public DateTime LastModifiedDate { get; set; }
}
