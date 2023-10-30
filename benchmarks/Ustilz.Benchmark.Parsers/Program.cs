using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using Microsoft.Extensions.DependencyInjection;

using Ustilz.Parsers.Csv;

BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

[HideColumns("Error", "StdDev", "Median", "RatioSD")]
[DisassemblyDiagnoser(0)]
public class Tests
{
    private string csv = new HttpClient().GetStringAsync(new Uri("https://projects.fivethirtyeight.com/soccer-api/international/2018/wc_matches.csv")).Result;

    private CsvParser parser;


    [GlobalSetup]
    public void Setup()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddLogging();
        services.AddMemoryCache();
        services.AddTransient<CsvParser>();
        this.parser = services.BuildServiceProvider().GetRequiredService<CsvParser>();
    }

    [Benchmark]
    public int Parse() => this.parser.;

    internal interface IValueProducer
    {
        int GetValue();
    }

    private class Producer42 : IValueProducer
    {
        public int GetValue() => 42;
    }
}
