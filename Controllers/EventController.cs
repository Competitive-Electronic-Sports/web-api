using Microsoft.AspNetCore.Mvc;
using web_api.Models;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    [HttpGet(Name = "GetAllEvents")]
    public IEnumerable<Event> Get()
    {
        var events = new List<Event> { new Event() };

        return events;
    }
}