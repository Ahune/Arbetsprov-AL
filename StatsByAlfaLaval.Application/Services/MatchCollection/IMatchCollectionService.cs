using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.MatchCollection;

public interface IMatchCollectionService
{
    IList<Match>? CleanByRegex(string rawSource);

    List<IList<Match>> CleanByRegex(IEnumerable<string> strResult);

}