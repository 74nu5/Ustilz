namespace Ustilz.Logging.Action;

using System;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

/// <summary>Classe d'extensions du logger d'action.</summary>
[PublicAPI]
public static class LoggerActionExtensions
{
    /// <summary>Méthode d'ajout du logger d'action au services du builder.</summary>
    /// <param name="builder">Builder de log de l'application.</param>
    /// <param name="action">Action à effectuer.</param>
    /// <returns>Retourne le builder de logger.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="action" /> is <see langword="null" />.</exception>
    public static ILoggingBuilder AddLoggerEvent(this ILoggingBuilder builder, LoggerAction.LogDelegate action)
    {
        ArgumentNullException.ThrowIfNull(builder);

        ArgumentNullException.ThrowIfNull(action);

        builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerProvider, LoggerActionProvider>(_ => new(action)));
        return builder;
    }
}
