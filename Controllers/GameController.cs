using Microsoft.AspNetCore.Mvc;
using web_api.Models;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    [HttpGet]
    public Game Get()
    {
        return new Game
        {
            Id = 1,
            Name = "Super Mario Bros",
        };
    }
}