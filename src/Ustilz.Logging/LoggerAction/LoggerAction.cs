namespace Ustilz.Logging.LoggerAction
{
    #region Usings

    using System;

    using Microsoft.Extensions.Logging;

    #endregion

    /// <summary>
    ///     Classe du logger d'action.
    /// </summary>
    public sealed class LoggerAction : ILogger
    {
        #region Champs

        private readonly LogDelegate action;

        private readonly string categoryName;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="LoggerAction" />.
        /// </summary>
        /// <param name="categoryName">Catégorie du log.</param>
        /// <param name="action">Action à effectuer lors du log.</param>
        internal LoggerAction(string categoryName, LogDelegate action)
        {
            this.categoryName = categoryName;
            this.action = action;
        }

        #endregion

        #region Delegates

        /// <summary>
        ///     Délégué représentant l'action à effectuer lors du log.
        /// </summary>
        /// <param name="categoryName">Nom de la catégorie du log.</param>
        /// <param name="logLevel">Niveau de log.</param>
        /// <param name="eventId">Identifiant de l'évènement.</param>
        /// <param name="exception">Exception levée, null s'il n'y en a pas.</param>
        /// <param name="message">Message à loguer.</param>
        public delegate void LogDelegate(string categoryName, LogLevel logLevel, EventId eventId, Exception exception, string message);

        #endregion

        #region Méthodes publiques

        /// <inheritdoc />
        public IDisposable? BeginScope<TState>(TState state) => null;

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => this.action != null;

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            => this.action(this.categoryName, logLevel, eventId, exception, formatter(state, exception));

        #endregion
    }
}
