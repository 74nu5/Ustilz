namespace Ustilz.Benchmark.Parsers.Models;

using Ustilz.Benchmark.Parsers.Abstractions;
using Ustilz.Parsers.Csv.Attributes;

internal class CityTemperature : ICityTemperature
{
    [CsvColumn<string>("City", Index = 0)]
    public string City { get; set; }

    [CsvColumnNumber<double>("Temperature", Index = 1)]
    public double Temperature { get; set; }
}
