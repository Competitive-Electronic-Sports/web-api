using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class RoundController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public RoundController(CESGamingContext context)
    {
        _context = context;
    }
}