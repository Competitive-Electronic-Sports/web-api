using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Models;

public class Game
{
    [Column("id")]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Event> Events { get; set; }
}