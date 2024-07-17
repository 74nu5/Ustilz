namespace Ustilz.Benchmark.Parsers.Models;

using Ustilz.Benchmark.Parsers.Abstractions;
using Ustilz.Parsers.Csv.Attributes;

public class Match : IMatch
{
    [CsvColumnDateTime("Date")]
    public DateTime Date { get; set; }

    [CsvColumnNumber<int>("LeagueId")]
    public int LeagueId { get; set; }

    [CsvColumn<string>("League")]
    public string League { get; set; }

    [CsvColumn<string>("Team1")]
    public string Team1 { get; set; }

    [CsvColumn<string>("Team2")]
    public string Team2 { get; set; }

    [CsvColumnNumber<double>("Spi1")]
    public double Spi1 { get; set; }

    [CsvColumnNumber<double>("Spi2")]
    public double Spi2 { get; set; }

    [CsvColumnNumber<double>("Prob1")]
    public double Prob1 { get; set; }

    [CsvColumnNumber<double>("Prob2")]
    public double Prob2 { get; set; }

    [CsvColumnNumber<double>("ProbTie")]
    public double ProbTie { get; set; }

    [CsvColumnNumber<double>("ProjScore1")]
    public double ProjScore1 { get; set; }

    [CsvColumnNumber<double>("ProjScore2")]
    public double ProjScore2 { get; set; }

    [CsvColumnNumber<int>("Score1")]
    public int Score1 { get; set; }

    [CsvColumnNumber<int>("Score2")]
    public int Score2 { get; set; }

    [CsvColumnNumber<double>("Xg1")]
    public double Xg1 { get; set; }

    [CsvColumnNumber<double>("Xg2")]
    public double Xg2 { get; set; }

    [CsvColumnNumber<double>("Nsxg1")]
    public double Nsxg1 { get; set; }

    [CsvColumnNumber<double>("Nsxg2")]
    public double Nsxg2 { get; set; }

    [CsvColumnNumber<double>("AdjScore1")]
    public double AdjScore1 { get; set; }

    [CsvColumnNumber<double>("AdjScore2")]
    public double AdjScore2 { get; set; }
}
