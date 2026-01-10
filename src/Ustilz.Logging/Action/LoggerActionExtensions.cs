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
    extension(ILoggingBuilder builder)
    {
        /// <summary>Méthode d'ajout du logger d'action au services du builder.</summary>
        /// <returns>Retourne le builder de logger.</returns>
        /// <exception cref="ArgumentNullException">builder is <see langword="null" />.</exception>
        /// <exception cref="ArgumentNullException">action is <see langword="null" />.</exception>
        public ILoggingBuilder AddLoggerEvent(LoggerAction.LogDelegate action)
        {
            ArgumentNullException.ThrowIfNull(builder);

            ArgumentNullException.ThrowIfNull(action);

            builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerProvider, LoggerActionProvider>(_ => new(action)));
            return builder;
        }
    }
}
