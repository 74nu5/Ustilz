namespace Ustilz.Logging.LoggerAction
{
    #region Usings

    using System.Collections.Concurrent;

    using Microsoft.Extensions.Logging;

    #endregion

    /// <summary>
    ///     Classe du provider du logger d'action.
    /// </summary>
    internal sealed class LoggerActionProvider : ILoggerProvider
    {
        #region Champs

        private readonly LoggerAction.LogDelegate action;

        private readonly ConcurrentDictionary<string, LoggerAction> loggers = new ConcurrentDictionary<string, LoggerAction>();

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="LoggerActionProvider" />.
        /// </summary>
        /// <param name="action">Action à effectuer lors du log.</param>
        public LoggerActionProvider(LoggerAction.LogDelegate action) => this.action = action;

        #endregion

        #region Méthodes publiques

        /// <summary>
        ///     Méthode de création du logger.
        /// </summary>
        /// <param name="categoryName">Nom de la catégorie du logger.</param>
        /// <returns>Retourne le logger.</returns>
        public ILogger CreateLogger(string categoryName) => this.loggers.GetOrAdd(categoryName, this.LoggerActionFactory);

        /// <inheritdoc />
        public void Dispose() => this.loggers.Clear();

        #endregion

        #region Méthodes privées

        private LoggerAction LoggerActionFactory(string categoryName) => new LoggerAction(categoryName, this.action);

        #endregion
    }
}
