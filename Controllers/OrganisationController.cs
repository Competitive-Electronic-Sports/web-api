using Microsoft.AspNetCore.Mvc;
using web_api.Data;
using web_api.Models;

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
    
    [HttpGet]
    public IEnumerable<Organisation> GetOrganisations()
    {
        return _context.Organisations;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Organisation>> GetOrganisation(int id)
    {
        var organisation = await _context.Organisations.FindAsync(id);
        
        if (organisation == null)
        {
            return NotFound();
        }
        
        return organisation;
    }
}