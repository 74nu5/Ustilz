namespace Ustilz.Logging.Console;

public class Reporter : IReporter
{
    private static readonly Reporter NullReporter = new(null);

    private static readonly object @lock = new();

    private readonly AnsiConsole? console;

    static Reporter()
        => Reset();

    private Reporter(AnsiConsole? console)
        => this.console = console;

    public static Reporter Error { get; private set; }

    public static bool IsVerbose { get; set; }

    public static Reporter Output { get; private set; }

    public static bool ShouldPassAnsiCodesThrough { get; set; }

    public static Reporter Verbose { get; private set; }

    /// <summary>
    ///     Resets the Reporters to write to the current Console Out/Error.
    /// </summary>
    public static void Reset()
    {
        lock (@lock)
        {
            Output = new(AnsiConsole.GetOutput());
            Error = new(AnsiConsole.GetError());
            Verbose = IsVerbose ? new(AnsiConsole.GetOutput()) : NullReporter;
        }
    }

    public void Write(string message)
    {
        lock (@lock)
        {
            if (ShouldPassAnsiCodesThrough)
            {
                this.console?.Writer?.Write(message);
            }
            else
            {
                this.console?.Write(message);
            }
        }
    }

    public void WriteLine(string message)
    {
        lock (@lock)
        {
            if (ShouldPassAnsiCodesThrough)
            {
                this.console?.Writer?.WriteLine(message);
            }
            else
            {
                this.console?.WriteLine(message);
            }
        }
    }

    public void WriteLine()
    {
        lock (@lock)
        {
            this.console?.Writer?.WriteLine();
        }
    }
}