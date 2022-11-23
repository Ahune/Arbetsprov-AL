using StatsByAlfaLaval.Application.Services.Statistics;

namespace StatsByAlfaLaval.Application.Services.TextStatistics;

public interface ITextStatisticsService
{
    TextStatisticResult TopWords(int n, List<Dictionary<string, long>> stringResult);
    LongestWordResult LongestWords(int n, List<Dictionary<string, long>> listOfDictionary);
}