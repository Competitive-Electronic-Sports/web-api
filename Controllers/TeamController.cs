using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public TeamController(CESGamingContext context)
    {
        _context = context;
    }
}