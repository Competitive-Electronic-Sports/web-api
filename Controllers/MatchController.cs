using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public MatchController(CESGamingContext context)
    {
        _context = context;
    }
}