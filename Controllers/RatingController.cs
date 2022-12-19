using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class RatingController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public RatingController(CESGamingContext context)
    {
        _context = context;
    }
}