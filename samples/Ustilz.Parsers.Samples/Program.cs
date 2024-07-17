using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Ustilz.Parsers.Extensions;
using Ustilz.Parsers.Samples.Parsers;

var hostBuilder = Host.CreateDefaultBuilder();
hostBuilder.ConfigureServices((_, services) =>
{
    services.AddParsers();
    services.AddTransient<OneBillionRowChallengeParser>();
});

//hostBuilder.ConfigureLogging(builder => builder.ClearProviders().AddConsole().AddDebug().SetMinimumLevel(LogLevel.Debug));

hostBuilder.UseConsoleLifetime();

var build = hostBuilder.Build();

var parser = build.Services.GetRequiredService<OneBillionRowChallengeParser>();
parser.Parse(@"C:\Temp\1brc\measurements-10_000.txt",
    new()
    {
        HasHeader = false,
        MaxLineLength = 256,
        Separator = ';',
    });