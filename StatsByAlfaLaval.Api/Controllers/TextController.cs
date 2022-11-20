using Microsoft.AspNetCore.Mvc;
using StatsByAlfaLaval.Application.Services.TextService;
using StatsByAlftaLaval.Contracts.TextData;

namespace StatsByAlfaLaval.Api.Controllers;


[ApiController]
[Route("text")]
public class TextController : ControllerBase
{
    private readonly ITextService _textService;

    public TextController(ITextService textService)
    {
        _textService = textService;
    }
    
    [HttpPost("gettext")]
    public IActionResult GetText(TextRequest request)
    {
        var textResult =
            _textService.GetArticleString(request.Urls);

            var response = new TextResponse(
            textResult.Response);

            return Ok(response);
    }
}