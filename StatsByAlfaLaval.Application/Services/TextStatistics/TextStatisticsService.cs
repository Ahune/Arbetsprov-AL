using StatsByAlftaLaval.Contracts;

namespace StatsByAlfaLaval.Application.Services.TextStatistics;

public class TextStatisticsService : ITextStatisticsService
{

    public TextStatisticResult TopWords(int n, List<Dictionary<string, long>> stringResult)
    {
        var hee = new List<List<WordFrequencyModel>>();
        foreach (var dict in stringResult)
        {
            var frequencies = 
                dict
                    .OrderByDescending(x => x.Value)
                    .Select(x => new WordFrequencyModel(x.Key, x.Value)
                    )
                    .Take(n)
                    .ToList();
            
            hee.Add(frequencies);
        }

        return new TextStatisticResult(hee);
    }

    public LongestWordResult LongestWords(int n, List<Dictionary<string, long>> listOfDictionary)
    {
        var list = new List<List<string>>();
        foreach (var dict in listOfDictionary)
        {
            var longestWord = 
                dict
                    .OrderByDescending(x => x.Key.Length)
                    .Select(x => new string(x.Key))
                    .Take(n)
                    .ToList();
            
            list.Add(longestWord);
        }

        return new LongestWordResult(list);
    }

    public long NumberOfWords(List<string> strResult)
    {
        throw new NotImplementedException();
    }

    public long NumberOfLines()
    {
        throw new NotImplementedException();
    }

}
