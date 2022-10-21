namespace Ustilz.Logging.Console;

public interface IReporter
{
    void WriteLine(string message);

    void WriteLine();

    void Write(string message);
}