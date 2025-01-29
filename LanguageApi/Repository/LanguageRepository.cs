namespace Repository;

public class LanguageRepository
{
    public List<string> getLanguageCodeList()
    {
        List<string> languageCodeList = new List<string>()
        {
            "en", 
            "dk"
        };
        return languageCodeList;
    }
}