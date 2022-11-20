namespace StatsByAlfaLaval.Application.Services.TextService;
    public interface ITextService
    {
        public TextResult GetArticleString(IEnumerable<string> urls);
    }
