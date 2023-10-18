namespace Ustilz.Logging.Console;

/// <summary>
///     Interface for a reporter.
/// </summary>
public interface IReporter
{
    /// <summary>
    ///     Writes a line to the console.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void WriteLine(string message);

    /// <summary>
    ///     Writes a line to the console.
    /// </summary>
    void WriteLine();

    /// <summary>
    ///     Writes a line to the console.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void Write(string message);
}
