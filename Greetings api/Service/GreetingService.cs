using Repository;

namespace Service;

public class GreetingService
{
    private readonly GreetingRepository _greetingRepository;

    public GreetingService(GreetingRepository greetingRepository)
    {
        _greetingRepository = greetingRepository;
    }

    public string GetGreeting(string language)
    {
        string greeting = _greetingRepository.GetGreeting(language);
        return greeting;
    }
}