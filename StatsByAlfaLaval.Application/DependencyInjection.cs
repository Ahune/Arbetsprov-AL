using Microsoft.Extensions.DependencyInjection;
using StatsByAlfaLaval.Application.Services.Authentication;
using StatsByAlfaLaval.Application.Services.TextService;
using StatsByAlfaLaval.Application.Services.TextStatistics;
using StatsByAlfaLaval.Application.Services.MatchCollection;
using StatsByAlfaLaval.Application.Services.Statistics;

namespace StatsByAlfaLaval.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ITextStatisticsService, TextStatisticsService>();
        services.AddScoped<ITextService, TextService>();
        services.AddScoped<IWordFrequencyService, WordFrequencyService>();
        services.AddScoped<IMatchCollectionService, MatchCollectionService>();
        services.AddHttpClient();
        
        return services;
    }
}