namespace Ustilz.Benchmark.Parsers.Parsers;

using JetBrains.Annotations;using Microsoft.Extensions.Caching.Memory;

using Microsoft.Extensions.Logging;

using Ustilz.Benchmark.Parsers.Abstractions;
using Ustilz.Benchmark.Parsers.Models;
using Ustilz.Parsers.Csv;

internal sealed class OneBillionRowChallengeParser(IMemoryCache memoryCache, ILogger<CsvParser> logger) : CsvParser(memoryCache, logger)
{
    public void Parse([NotNull] string csv, CsvParsingOptions options)
        => _ = this.Parse<ICityTemperature, CityTemperature>(csv, options, (_, _) => { });
}
