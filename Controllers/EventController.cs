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
    public IEnumerable<Event> GetEvents()
    {
        return _context.Events;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEvent(int id)
    {
        var searchedEvent = await _context.Events.FindAsync(id);

        if (searchedEvent == null)
        {
            return NotFound();
        }

        return searchedEvent;
    }
    
    // [HttpPost(Name = "CreateNewEvent")]
    // public async Task<ActionResult<Event>> CreateEvent(Event newEvent)
    // {
    //     _context.Events.Add(newEvent);
    //     await _context.SaveChangesAsync();
    //     return CreatedAtAction("GetEvent", )
    // }
}