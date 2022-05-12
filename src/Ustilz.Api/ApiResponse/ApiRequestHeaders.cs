namespace Ustilz.Api.ApiResponse;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Http;

using Ustilz.Models;

/// <summary>
///     Record which represents the eat mapi headers request.
/// </summary>
/// <param name="CorrelationId">The correlation id.</param>
/// <param name="FunctionalId">The functional id.</param>
/// <param name="TechnicalId">The technical id.</param>
[PublicAPI]
public sealed record ApiRequestHeaders(Guid CorrelationId, string FunctionalId, Guid TechnicalId) : ServiceMonitoringDefinition(CorrelationId, FunctionalId, TechnicalId)
{
    /// <summary>
    ///     Method which bind monitoring ids present in the headers to a <see cref="ApiRequestHeaders" /> object.
    /// </summary>
    /// <param name="context">The http context.</param>
    /// <returns>Returns the headers object.</returns>
    [UsedImplicitly]
    public static ValueTask<ApiRequestHeaders?> BindAsync(HttpContext context)
    {
        _ = Guid.TryParse(context.Request.Headers[CorrelationIdKey], out var correlationIdHeader);
        _ = Guid.TryParse(context.Request.Headers[TechnicalIdKey], out var technicalIdKeyHeader);

        var result = new ApiRequestHeaders(correlationIdHeader, context.Request.Headers[FunctionalIdKey], technicalIdKeyHeader);

        return ValueTask.FromResult<ApiRequestHeaders?>(result);
    }
}
