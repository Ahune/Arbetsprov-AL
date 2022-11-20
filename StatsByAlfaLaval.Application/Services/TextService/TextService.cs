namespace StatsByAlfaLaval.Application.Services.TextService;

public class TextService : ITextService
{
    private readonly HttpClient _httpClient;
	public TextService(IHttpClientFactory httpClient)
    {
        _httpClient = httpClient.CreateClient();
    }

    public TextResult GetArticleString(IEnumerable<string> urls)
    {
        return new TextResult(ReadTextAsync(urls, _httpClient));
    }
    private List<string> ReadTextAsync(IEnumerable<string> sourcePath, HttpClient httpClient)
    {
        return sourcePath.Select(link => httpClient.GetStringAsync(link).Result).ToList();
    }
}