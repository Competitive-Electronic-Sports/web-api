namespace web_api.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TeamSize { get; set; }
    public int PlayingTeamSize { get; set; }
    public int EntryFee { get; set; }
    public int LowerRankLimit { get; set; }
    public int UpperRankLimit { get; set; }
    
    public int ChallongeId { get; set; }
    
    public Game Game { get; set; }
    public Organisation Organisation { get; set; }
    
    public ICollection<Round> Rounds { get; set; }
}