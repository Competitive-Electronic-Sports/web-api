using Microsoft.AspNetCore.Mvc;
using web_api.Data;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrganisationController : ControllerBase
{
    private readonly CESGamingContext _context;
    
    public OrganisationController(CESGamingContext context)
    {
        _context = context;
    }
}