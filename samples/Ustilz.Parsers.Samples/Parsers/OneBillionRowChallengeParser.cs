namespace Ustilz.Parsers.Samples.Parsers;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using Ustilz.Parsers.Csv;
using Ustilz.Parsers.Samples.Abstractions;
using Ustilz.Parsers.Samples.Models;

internal class OneBillionRowChallengeParser(IMemoryCache cache, ILogger<CsvParser> logger, IServiceProvider serviceProvider) : CsvParser(cache, logger, serviceProvider)
{
    public void Parse(string csv, CsvParsingOptions options)
    {
        var result = this.Parse<ICityTemperature, CityTemperature>(csv, options, (_, _) => { });
    }
}
