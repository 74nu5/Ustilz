namespace Ustilz.Logging.LoggerAction
{
    #region Usings

    using JetBrains.Annotations;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Microsoft.Extensions.Logging;

    #endregion

    /// <summary>
    ///     Classe d'extensions du logger d'action.
    /// </summary>
    [PublicAPI]
    public static class LoggerActionExtensions
    {
        #region Méthodes publiques

        /// <summary>
        ///     Méthode d'ajout du logger d'action au services du builder.
        /// </summary>
        /// <param name="builder">Builder de log de l'application.</param>
        /// <param name="action">Action à effectuer.</param>
        /// <returns>Retourne le builder de logger.</returns>
        public static ILoggingBuilder AddLoggerEvent(this ILoggingBuilder builder, LoggerAction.LogDelegate action)
        {
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerProvider, LoggerActionProvider>(serviceProvider => new LoggerActionProvider(action)));
            return builder;
        }

        #endregion
    }
}
