using Greetings_api.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Greetings_api.Controller;

[ApiController]
public class GreetingController : ControllerBase
{
    private readonly GreetingService _service;

    public GreetingController(GreetingService service)
    {
        _service = service;
    }

    [HttpPost()]
    [Route("/greetings")]
    public GreetingModel getGreeting([FromBody] LanguageDto languageDto)
    {
        var greeting = _service.GetGreeting(languageDto.language);
        return new GreetingModel
        {
            Greeting = greeting
        };
    }
}