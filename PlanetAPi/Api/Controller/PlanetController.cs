using Greetings_api.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Api.Controller;

[ApiController]
public class PlanetController : ControllerBase
{
    private readonly PlanetService _service;

    public PlanetController(PlanetService service)
    {
        _service = service;
    }

    [HttpPost()]
    [Route("/planets")]
    public List<String> getPlanets([FromBody] LanguageDto languageDto)
    {
        return _service.getPlanets(languageDto.language.ToUpper());
    }
}