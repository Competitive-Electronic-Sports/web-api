using System.Collections;

namespace web_api.Models;

public class Round
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public Event Event { get; set; }
    
    public int BestOf { get; set; }
    public int BansPerTeam { get; set; }
    
    public ICollection<Match> Matches { get; set; }
    public ICollection<Map> MapPool { get; set; }
}