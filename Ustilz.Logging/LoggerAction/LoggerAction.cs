namespace Ustilz.Logging.LoggerEvent
{
    #region Usings

    using System;

    using Microsoft.Extensions.Logging;

    #endregion

    public class LoggerAction : ILogger
    {
        #region Champs

        private readonly LogDelegate action;

        private readonly string categoryName;

        #endregion

        #region Constructeurs et destructeurs

        public LoggerAction(string categoryName, LogDelegate action)
        {
            this.categoryName = categoryName;
            this.action = action;
        }

        #endregion

        #region Delegates

        public delegate void LogDelegate(string categoryName, LogLevel logLevel, EventId eventId, Exception exception, string message);

        #endregion

        #region Méthodes publiques

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => this.action != null;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            this.action(this.categoryName, logLevel, eventId, exception, formatter(state, exception));
        }

        #endregion
    }
}
