using Microsoft.AspNetCore.Mvc;
using StatsByAlfaLaval.Application.Services.MatchCollection;
using StatsByAlfaLaval.Application.Services.Statistics;
using StatsByAlfaLaval.Application.Services.TextService;
using StatsByAlfaLaval.Application.Services.TextStatistics;
using StatsByAlftaLaval.Contracts.TextStatistics;

namespace StatsByAlfaLaval.Api.Controllers;

[ApiController]
[Route("stats")]
public class TextStatisticController : ControllerBase
{
    private readonly ITextStatisticsService _textStatisticsService;
    private readonly IWordFrequencyService _wordFrequencyService;
    private readonly IMatchCollectionService _matchCollection;
    private readonly ITextService _textService;
    
    public TextStatisticController(ITextStatisticsService textStatisticsService, 
        IWordFrequencyService wordFrequencyService, IMatchCollectionService matchCollection, ITextService textService)
    {
        _textStatisticsService = textStatisticsService;
        _wordFrequencyService = wordFrequencyService;
        _matchCollection = matchCollection;
        _textService = textService;
    }
    
    [HttpGet("topwords")]
    public IActionResult ComputeFrequency([FromBody] TextStatisticRequest request)
    {
        var textResult = _textService.GetArticleString(request.Urls);
        
        var getMatchCollection = _matchCollection.CleanByRegex(textResult.Response);

        var words = _wordFrequencyService.CountingWordsToDictionary(getMatchCollection);
        
        var statResult = _textStatisticsService.TopWords(request.NumberOfWordsToDisplay, words);

        var response = new TextStatisticResponse(statResult.ListOfWordFrequency);
        
        return Ok(response);
    }
    
    [HttpGet("getlongestword")]
    public IActionResult GetLongestWord([FromBody] TextStatisticRequest request)
    {
        var textResult = _textService.GetArticleString(request.Urls);

        var getMatchCollection = _matchCollection.CleanByRegex(textResult.Response);

        var words = _wordFrequencyService.CountingWordsToDictionary(getMatchCollection);
        
        var longestResult = _textStatisticsService.LongestWords(
            request.NumberOfWordsToDisplay, words);

        var response = new LongestWordResult(longestResult.LongestWords);
        
        return Ok(response);
    }
}