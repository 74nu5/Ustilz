namespace Ustilz.Data.Entities;

using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
///     Class that represents an entity whose state can be monitored.
/// </summary>
public class AStateDataObject<TIdentity> : ADataObject<TIdentity>
    where TIdentity : IComparable<TIdentity>
{
    /// <summary>
    ///     Gets or sets the state id.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid StateFlowId { get; set; }
}
