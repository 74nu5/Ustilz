namespace Ustilz.Benchmark.Parsers.Abstractions;

internal interface IMatch
{
    DateTime Date { get; set; }

    int LeagueId { get; set; }

    string League { get; set; }

    string Team1 { get; set; }

    string Team2 { get; set; }

    double Spi1 { get; set; }

    double Spi2 { get; set; }

    double Prob1 { get; set; }

    double Prob2 { get; set; }

    double ProbTie { get; set; }

    double ProjScore1 { get; set; }

    double ProjScore2 { get; set; }

    int Score1 { get; set; }

    int Score2 { get; set; }

    double Xg1 { get; set; }

    double Xg2 { get; set; }

    double Nsxg1 { get; set; }

    double Nsxg2 { get; set; }

    double AdjScore1 { get; set; }

    double AdjScore2 { get; set; }
}
