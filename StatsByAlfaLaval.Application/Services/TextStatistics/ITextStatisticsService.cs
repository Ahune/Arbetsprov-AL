using StatsByAlfaLaval.Application.Services.Statistics;

namespace StatsByAlfaLaval.Application.Services.TextStatistics;

public interface ITextStatisticsService
{
    /** 
    * Returns a list of the most frequented words of the text. 
    * @param n how many items of the list 
    * @return a list representing the top n frequent words of the text. 
    */

    //List<List<WordFrequency>> TopWords(int n, List<string> strResult);

    TextStatisticResult TopWords(int n, List<Dictionary<string, long>> stringResult);
    /** 
    * Returns a list of the longest words of the text. 
    * @param n how many items to return. 
    * @return a list with the n longest words of the text. 
    */

    LongestWordResult LongestWords(int n, List<Dictionary<string, long>> listOfDictionary);

    /** 
    * @return total number of words in the text. 
    */ 

    long NumberOfWords(List<string> strResult); 

    /** 
    * @return total number of line of the text. 
    */ 

    long NumberOfLines();

    
}