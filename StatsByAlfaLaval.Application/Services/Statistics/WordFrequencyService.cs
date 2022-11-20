using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.Statistics;

public class WordFrequencyService : IWordFrequencyService
{

    public string Word()
    {
        return "frequentWord";
    }

    public long Frequency()
    {
        return 0;
    }

    public List<Dictionary<string, long>> CountingWordsToDictionary(List<IList<Match>> words)
    {
        var listOfDict = new List<Dictionary<string, long>>(); //(StringComparer.OrdinalIgnoreCase)

        foreach (var list in words)
        {
            var dictionary = new Dictionary<string, long>(StringComparer.OrdinalIgnoreCase); //the THE samma key

            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Value.Length < 3) continue; // at least 3 letters and has any letters
                if (dictionary.ContainsKey(list[i].Value))
                    dictionary[list[i].Value] = dictionary[list[i].Value] + 1;
                else
                    dictionary[list[i].Value] = 1;
            }
            listOfDict.Add(dictionary);
    
        }
        
        // merge:a dicts om word > 1 eller göra det efter take?
        if (words.Count > 1)
            return MergeDictionaries(listOfDict);


        return listOfDict;
    }

    private List<Dictionary<string, long>> MergeDictionaries(List<Dictionary<string, long>> listOfDict)
    {
            Dictionary<string, long> newDict = new();		

            foreach(var dict in listOfDict){
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