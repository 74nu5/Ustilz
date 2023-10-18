namespace Ustilz.Logging.Console;

#region Usings

using JetBrains.Annotations;

using Console = System.Console;

#endregion

/// <summary>
///     Class to write to the console using ANSI escape sequences.
/// </summary>
[PublicAPI]
public sealed class AnsiConsole
{
    private const int Light = 0x08;

    private int boldRecursion;

    private AnsiConsole(TextWriter writer)
    {
        this.Writer = writer;

        this.OriginalForegroundColor = Console.ForegroundColor;
        this.boldRecursion = ((int)this.OriginalForegroundColor & Light) != 0 ? 1 : 0;
    }

    /// <summary>
    ///     Gets the original foreground color of the console.
    /// </summary>
    public ConsoleColor OriginalForegroundColor { get; }

    /// <summary>
    ///     Gets the <see cref="TextWriter" /> to write to.
    /// </summary>
    public TextWriter Writer { get; }

    /// <summary>
    ///     Gets the error console.
    /// </summary>
    /// <returns>The <see cref="AnsiConsole" />.</returns>
    public static AnsiConsole GetError()
        => new(Console.Error);

    /// <summary>
    ///     Gets the output console.
    /// </summary>
    /// <returns>The <see cref="AnsiConsole" />.</returns>
    public static AnsiConsole GetOutput()
        => new(Console.Out);


    /// <summary>
    ///     Writes the message to the console.
    /// </summary>
    /// <param name="message">The message to write.</param>
    public void Write(string message)
    {
        var escapeScan = 0;

        for (;;)
        {
            var escapeIndex = message.IndexOf("\x1b[", escapeScan, StringComparison.Ordinal);

            if (escapeIndex == -1)
            {
                var text = message[escapeScan..];
                this.Writer.Write(text);
                break;
            }
            else
            {
                var startIndex = escapeIndex + 2;
                var endIndex = startIndex;

                while (endIndex != message.Length &&
                       message[endIndex] >= 0x20 &&
                       message[endIndex] <= 0x3f)
                {
                    endIndex += 1;
                }

                var text = message.Substring(escapeScan, escapeIndex - escapeScan);
                this.Writer.Write(text);

                if (endIndex == message.Length)
                {
                    break;
                }

                switch (message[endIndex])
                {
                    case 'm':
                        if (int.TryParse(message.Substring(startIndex, endIndex - startIndex), out var value))
                        {
                            switch (value)
                            {
                                case 1:
                                    this.SetBold(true);
                                    break;
                                case 22:
                                    this.SetBold(false);
                                    break;
                                case 30:
                                    this.SetColor(ConsoleColor.Black);
                                    break;
                                case 31:
                                    this.SetColor(ConsoleColor.Red);
                                    break;
                                case 32:
                                    this.SetColor(ConsoleColor.Green);
                                    break;
                                case 33:
                                    this.SetColor(ConsoleColor.Yellow);
                                    break;
                                case 34:
                                    this.SetColor(ConsoleColor.Blue);
                                    break;
                                case 35:
                                    this.SetColor(ConsoleColor.Magenta);
                                    break;
                                case 36:
                                    this.SetColor(ConsoleColor.Cyan);
                                    break;
                                case 37:
                                    this.SetColor(ConsoleColor.Gray);
                                    break;
                                case 39:
                                    Console.ForegroundColor = this.OriginalForegroundColor;
                                    break;
                            }
                        }

                        break;
                }

                escapeScan = endIndex + 1;
            }
        }
    }

    /// <summary>
    ///     Writes the message to the console.
    /// </summary>
    /// <param name="message">The message to write.</param>
    public void WriteLine(string message)
    {
        this.Write(message);
        this.Writer.WriteLine();
    }

    private void SetBold(bool bold)
    {
        this.boldRecursion += bold ? 1 : -1;

        if (this.boldRecursion > 1 || (this.boldRecursion == 1 && !bold))
        {
            return;
        }

        // switches on boldRecursion to handle boldness
        this.SetColor(Console.ForegroundColor);
    }

    private void SetColor(ConsoleColor color)
    {
        var c = (int)color;

        Console.ForegroundColor =
            c < 0 ? color : // unknown, just use it
            this.boldRecursion > 0 ? (ConsoleColor)(c | Light) : // ensure color is light
            (ConsoleColor)(c & ~Light); // ensure color is dark
    }
}
