namespace Ustilz.Logging.LoggerEvent
{
    #region Usings

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Microsoft.Extensions.Logging;

    #endregion

    public static class LoggerActionExtensions
    {
        #region Méthodes publiques

        public static ILoggingBuilder AddLoggerEvent(this ILoggingBuilder builder, LoggerAction.LogDelegate action)
        {
            builder.Services.TryAdd(ServiceDescriptor.Singleton<ILoggerProvider, LoggerActionProvider>(serviceProvider => new LoggerActionProvider(action)));
            return builder;
        }

        #endregion
    }
}
