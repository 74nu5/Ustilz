namespace Ustilz.Parsers.Samples.Parsers;

using Microsoft.Extensions.Logging;

using Ustilz.Parsers.Csv;
using Ustilz.Parsers.Samples.Abstractions;
using Ustilz.Parsers.Samples.Models;

internal sealed class OneBillionRowChallengeParser(ILogger<CsvParser> logger, IServiceProvider serviceProvider) : CsvParser(logger, serviceProvider)
{
    public void Parse(string csv, CsvParsingOptions options)
        => _ = this.Parse<ICityTemperature, CityTemperature>(csv, options, (_, _) => { });
}
