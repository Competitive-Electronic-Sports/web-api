using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public UserController(CESGamingContext context)
    {
        _context = context;
    }
}