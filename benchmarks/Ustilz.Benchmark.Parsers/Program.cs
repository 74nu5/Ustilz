using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Running;

using Microsoft.Extensions.DependencyInjection;

using Ustilz.Benchmark.Parsers.Parsers;

BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Error", "StdDev", "Median", "RatioSD")]
[DisassemblyDiagnoser(0)]
[MemoryDiagnoser]
[NativeMemoryProfiler]
[ThreadingDiagnoser]
[ExceptionDiagnoser]
public class Tests
{
    private readonly string csv = new HttpClient().GetStringAsync(new Uri("https://projects.fivethirtyeight.com/soccer-api/international/2018/wc_matches.csv")).Result;

    private WorldCupMatchesParser worldCupMatchesParser;
    private OneBillionRowChallengeParser oneBillionRowChallengeParser;
    private string csvWorldCupTemp;


    [GlobalSetup]
    public void Setup()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddLogging();
        services.AddMemoryCache();
        services.AddTransient<WorldCupMatchesParser>();
        services.AddTransient<OneBillionRowChallengeParser>();
        this.worldCupMatchesParser = services.BuildServiceProvider().GetRequiredService<WorldCupMatchesParser>();
        this.oneBillionRowChallengeParser = services.BuildServiceProvider().GetRequiredService<OneBillionRowChallengeParser>();
        this.csvWorldCupTemp = Path.GetTempFileName();
        File.WriteAllText(this.csvWorldCupTemp, this.csv);
    }

    //[Benchmark]
    public void ParseWorlCupResult() => this.worldCupMatchesParser.Parse(this.csvWorldCupTemp,
        new()
        {
            HasHeader = true,
            MaxLineLength = 256,
            Separator = ',',
        });


    [Benchmark]
    public void Parse1Brc() => this.oneBillionRowChallengeParser.Parse(@"C:\Temp\1brc\measurements-10_000.txt",
        new()
        {
            HasHeader = false,
            MaxLineLength = 256,
            Separator = ';',
        });
}
