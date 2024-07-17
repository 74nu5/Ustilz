namespace Ustilz.Parsers.Samples.Models;

using Ustilz.Parsers.Csv.Attributes;
using Ustilz.Parsers.Samples.Abstractions;

internal class CityTemperature : ICityTemperature
{
    [CsvColumn<string>("City", Index = 0)]
    public string City { get; set; }

    [CsvColumnNumber<double>("Temperature", Index = 1)]
    public double Temperature { get; set; }
}
