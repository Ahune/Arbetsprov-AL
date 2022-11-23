using StatsByAlfaLaval.Domain.Entities;
using StatsByAlftaLaval.Contracts;

namespace StatsByAlfaLaval.Application.Services.TextStatistics;

public record TextStatisticResult(List<List<WordFrequencyModel>>? ListOfWordFrequency);