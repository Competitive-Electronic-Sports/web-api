using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Models;

public class Event
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    [Column("team_size")]
    public int TeamSize { get; set; }
    
    [Column("playing_team_size")]
    public int PlayingTeamSize { get; set; }
    
    [Column("entry_fee")]
    public int EntryFee { get; set; }
    
    [Column("lower_rank_limit")]
    public int LowerRankLimit { get; set; }
    
    [Column("upper_rank_limit")]
    public int? UpperRankLimit { get; set; }
    
    [Column("challonge_id")]
    public string? ChallongeId { get; set; }
    
    [Column("game_id")]
    public int GameId { get; set; }
    public Game Game { get; set; }
    
    // public Organisation Organisation { get; set; }
    
    // public ICollection<Round> Rounds { get; set; }
}