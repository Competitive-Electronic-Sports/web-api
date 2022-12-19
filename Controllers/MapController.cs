using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MapController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public MapController(CESGamingContext context)
    {
        _context = context;
    }
}