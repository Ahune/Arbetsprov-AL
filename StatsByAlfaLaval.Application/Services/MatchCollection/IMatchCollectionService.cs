using System.Text.RegularExpressions;

namespace StatsByAlfaLaval.Application.Services.MatchCollection;

public interface IMatchCollectionService
{
    List<IList<Match>> CleanByRegex(IEnumerable<string> strResult);
}