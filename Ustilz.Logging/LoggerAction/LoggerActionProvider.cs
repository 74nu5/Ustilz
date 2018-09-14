namespace Ustilz.Logging.LoggerEvent
{
    #region Usings

    using System.Collections.Concurrent;

    using Microsoft.Extensions.Logging;

    #endregion

    public class LoggerActionProvider : ILoggerProvider
    {
        #region Champs

        private readonly LoggerAction.LogDelegate action;

        private readonly ConcurrentDictionary<string, LoggerAction> loggers = new ConcurrentDictionary<string, LoggerAction>();

        #endregion

        #region Constructeurs et destructeurs

        public LoggerActionProvider(LoggerAction.LogDelegate action) => this.action = action;

        #endregion

        #region Méthodes publiques

        public ILogger CreateLogger(string categoryName) => this.loggers.GetOrAdd(categoryName, this.CompilLoggerFactory);

        public void Dispose()
        {
        }

        #endregion

        #region Méthodes privées

        private LoggerAction CompilLoggerFactory(string categoryName) => new LoggerAction(categoryName, this.action);

        #endregion
    }
}
