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

    [HttpGet()]
    [Route("/greetings")]
    public MessageReturn getGreeting([FromQuery] string language)
    {
        var greeting = _service.GetGreeting(language);
        return new MessageReturn
        {
            message = greeting
        };
    }
}