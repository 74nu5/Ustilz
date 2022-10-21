namespace Ustilz.Logging.Action;

using System;
using System.Collections.Concurrent;

using Microsoft.Extensions.Logging;

/// <summary>Classe du provider du logger d'action.</summary>
internal sealed class LoggerActionProvider : ILoggerProvider
{
    private readonly LoggerAction.LogDelegate action;

    private readonly ConcurrentDictionary<string, LoggerAction> loggers = new ();

    /// <summary>Initialise une nouvelle instance de la classe <see cref="LoggerActionProvider" />.</summary>
    /// <param name="action">Action à effectuer lors du log.</param>
    public LoggerActionProvider(LoggerAction.LogDelegate action) => this.action = action;

    /// <summary>Méthode de création du logger.</summary>
    /// <param name="categoryName">Nom de la catégorie du logger.</param>
    /// <returns>Retourne le logger.</returns>
    /// <exception cref="OverflowException">The dictionary already contains the maximum number of elements (<see cref="int.MaxValue"></see>).</exception>
    /// <exception cref="ArgumentNullException">key or valueFactory is null.</exception>
    public ILogger CreateLogger(string categoryName) => this.loggers.GetOrAdd(categoryName, this.LoggerActionFactory);

    /// <inheritdoc />
    public void Dispose() => this.loggers.Clear();

    private LoggerAction LoggerActionFactory(string categoryName) => new (categoryName, this.action);
}