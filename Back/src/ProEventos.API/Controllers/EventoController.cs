using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
        
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return 
        "Value";
    }
}
