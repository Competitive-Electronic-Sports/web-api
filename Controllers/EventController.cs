using Microsoft.AspNetCore.Mvc;
using web_api.Data;
using web_api.Models;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public EventController(CESGamingContext context)
    {
        _context = context;
    }
    
    [HttpGet(Name = "GetAllEvents")]
    public IEnumerable<Event> Get()
    {
        return _context.Events;
    }
}