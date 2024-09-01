namespace Ustilz.Benchmark.Parsers.Parsers;

using JetBrains.Annotations;

using Microsoft.Extensions.Logging;

using Ustilz.Benchmark.Parsers.Abstractions;
using Ustilz.Benchmark.Parsers.Models;
using Ustilz.Parsers.Csv;

internal sealed class WorldCupMatchesParser([NotNull] ILogger<CsvParser> logger, IServiceProvider serviceProvider) : CsvParser(logger, serviceProvider)
{
    public void Parse([NotNull] string csv, CsvParsingOptions options)
        => _ = this.Parse<IMatch, Match>(csv, options, (_, _) => { });
}
