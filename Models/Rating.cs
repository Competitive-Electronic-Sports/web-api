namespace web_api.Models;

public class Rating
{
    public User User { get; set; }
    public Game Game { get; set; }
    public int RatingValue { get; set; }
}