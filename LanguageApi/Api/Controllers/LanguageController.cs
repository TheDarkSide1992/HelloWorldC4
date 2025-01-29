using Microsoft.AspNetCore.Mvc;
using Service;

namespace LanguageApi.Controllers;

[ApiController]
public class LanguageController : ControllerBase
{
    private readonly ILogger<LanguageController> _logger;
    private readonly LanguageService _service;
    
    public LanguageController(ILogger<LanguageController> logger, LanguageService service)
    {
        _logger = logger;
        _service = service;
    }
    
    [HttpGet]
    [Route("/getlanguage")]
    public List<string> GetLanguage()
    {
        return _service.GetLanguages();
    }
}