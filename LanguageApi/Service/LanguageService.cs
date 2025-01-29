using Repository;

namespace Service;

public class LanguageService
{
    private readonly LanguageRepository _languageRepository;

    public LanguageService(LanguageRepository languageRepository)
    {
        _languageRepository = languageRepository;
    }

    public List<string> GetLanguages()
    {
        return _languageRepository.getLanguageCodeList();
    }
}