namespace Ustilz.Data.Abstractions;

using JetBrains.Annotations;

/// <summary>
///     Classe qui représente un DTO avec suivi des dates de modifications.
/// </summary>
[PublicAPI]
public interface ITraceableDataObject
{
    /// <summary>
    ///     Gets or sets the date and time creation of the object.
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    ///     Gets or sets the date and time of the last modification of the object.
    /// </summary>
    public DateTime LastModifiedDate { get; set; }
}
