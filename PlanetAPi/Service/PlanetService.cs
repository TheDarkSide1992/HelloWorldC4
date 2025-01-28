using Repository;

namespace Service;

public class PlanetService
{
    private readonly PlanetRepository _planetRepository;

    public PlanetService(PlanetRepository planetRepository)
    {
        _planetRepository = planetRepository;
    }

    public List<String> getPlanets(string language)
    {
        List<String> greeting = _planetRepository.getPlanets(language);
        return greeting;
    }
}
