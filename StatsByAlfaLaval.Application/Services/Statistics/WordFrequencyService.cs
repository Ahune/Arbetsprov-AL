using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.Statistics;

public class WordFrequencyService : IWordFrequencyService
{
    public List<Dictionary<string, long>> CountingWordsToDictionary(List<IList<Match>> words)
    {
        var listOfDict = new List<Dictionary<string, long>>();

        foreach (var list in words)
        {
            var dictionary = new Dictionary<string, long>(StringComparer.OrdinalIgnoreCase); 

            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Value.Length < 3) continue;
                if (dictionary.ContainsKey(list[i].Value))
                    dictionary[list[i].Value] += 1;
                else
                    dictionary[list[i].Value] = 1;
            }
            listOfDict.Add(dictionary);
        }
        
        return words.Count > 1 ? MergeDictionaries(listOfDict) : listOfDict;
    }

    private static List<Dictionary<string, long>> MergeDictionaries(List<Dictionary<string, long>> listOfDict)
    {
            Dictionary<string, long> newDict = new();		

            foreach(var dict in listOfDict)
            {
                foreach (var kvp in dict)
                {
                    if (newDict.ContainsKey(kvp.Key))
                    {
                        newDict[kvp.Key] += kvp.Value;
                    }
                    else
                    {
                        newDict.Add(kvp.Key, kvp.Value);
                    }
                }
            }
            
            listOfDict.Add(newDict);
            return listOfDict;
    }
}