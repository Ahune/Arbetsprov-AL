using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.Statistics;

public interface IWordFrequencyService
{

    List<Dictionary<string, long>> CountingWordsToDictionary(List<IList<Match>> words);
}