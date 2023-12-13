namespace Ustilz.Logging.Console;

using System.Diagnostics.CodeAnalysis;

using JetBrains.Annotations;

/// <summary>
///     Class to write to the console using ANSI escape sequences.
/// </summary>
[PublicAPI]
public class Reporter : IReporter
{
    private static readonly Reporter NullReporter = new(null);

    private static readonly object Lock = new();

    private readonly AnsiConsole? console;

    static Reporter()
        => Reset();

    private Reporter(AnsiConsole? console)
        => this.console = console;

    /// <summary>
    ///     Gets the error console.
    /// </summary>
    public static Reporter Error { get; private set; }

    /// <summary>
    ///     Gets the output console.
    /// </summary>
    public static Reporter Output { get; private set; }

    /// <summary>
    ///     Gets the verbose console.
    /// </summary>
    public static Reporter Verbose { get; private set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the console should be verbose.
    /// </summary>
    public static bool IsVerbose { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether ANSI codes should be passed through.
    /// </summary>
    public static bool ShouldPassAnsiCodesThrough { get; set; }

    /// <summary>
    ///     Resets the Reporters to write to the current Console Out/Error.
    /// </summary>
    [MemberNotNull(nameof(Output))]
    [MemberNotNull(nameof(Error))]
    [MemberNotNull(nameof(Verbose))]
    public static void Reset()
    {
        lock (Lock)
        {
            Output = new(AnsiConsole.GetOutput());
            Error = new(AnsiConsole.GetError());
            Verbose = IsVerbose ? new(AnsiConsole.GetOutput()) : NullReporter;
        }
    }

    /// <inheritdoc />
    public void Write(string message)
    {
        lock (Lock)
        {
            if (ShouldPassAnsiCodesThrough)
                this.console?.Writer.Write(message);
            else
                this.console?.Write(message);
        }
    }

    /// <inheritdoc />
    public void WriteLine(string message)
    {
        lock (Lock)
        {
            if (ShouldPassAnsiCodesThrough)
                this.console?.Writer.WriteLine(message);
            else
                this.console?.WriteLine(message);
        }
    }

    /// <inheritdoc />
    public void WriteLine()
    {
        lock (Lock)
            this.console?.Writer.WriteLine();
    }
}
