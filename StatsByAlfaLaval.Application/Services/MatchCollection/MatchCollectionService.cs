using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.MatchCollection;

public class MatchCollectionService : IMatchCollectionService
{
    public IList<Match> CleanByRegex(string rawSource)
    {
        IList<Match> r = Regex.Matches(rawSource, "\\w+");
        return r;
    }

    public List<IList<Match>> CleanByRegex(IEnumerable<string> strResult)
    {
        return strResult.Select(result => Regex.Matches(result, "\\w+")).Cast<IList<Match>>().ToList();
    }
}