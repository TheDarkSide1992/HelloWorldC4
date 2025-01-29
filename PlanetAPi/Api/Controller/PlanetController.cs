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

    [HttpGet()]
    [Route("/planets")]
    public MessageReturn getPlanets([FromQuery] string language)
    {
        var planets = _service.getPlanets(language.ToUpper());
        var random = new Random();
        return new MessageReturn{message = planets[random.Next(planets.Count-1)]};
    }
}