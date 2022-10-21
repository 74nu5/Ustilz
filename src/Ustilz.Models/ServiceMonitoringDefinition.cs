namespace Ustilz.Models;

using JetBrains.Annotations;

[PublicAPI]
public record ServiceMonitoringDefinition(Guid CorrelationId, string FunctionalId)
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServiceMonitoringDefinition" /> class.
    /// </summary>
    /// <param name="functionalId">
    ///     The functional id.
    ///     <remarks>
    ///         Depends of functional process.
    ///     </remarks>
    /// </param>
    public ServiceMonitoringDefinition(string functionalId)
        : this(Guid.NewGuid(), functionalId)
    {
    }
}
