using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Models;

public class Rating
{
    public int UserId { get; set; }
    
    [Column("game_id")]
    public int GameId { get; set; }
    
    public User User { get; set; }
    public Game Game { get; set; }
    public int RatingValue { get; set; }
}