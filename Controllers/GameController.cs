using Microsoft.AspNetCore.Mvc;
using web_api.Data;
using web_api.Models;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public GameController(CESGamingContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IEnumerable<Game> Get()
    {
        return _context.Games;
    }
}