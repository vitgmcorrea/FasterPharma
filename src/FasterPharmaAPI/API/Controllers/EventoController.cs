using Microsoft.AspNetCore.Mvc;

namespace FasterPharmaAPI.Controllers;

[ApiController]
[Route("Api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController() { }

    [HttpGet]
    public string Get()
    {
        return "value";
    }
}
