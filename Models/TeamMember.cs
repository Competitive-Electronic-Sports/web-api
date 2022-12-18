namespace web_api.Models;

public class TeamMember
{
    public int TeamId { get; set; }
    public int PlayerId { get; set; }
    
    public Team Team { get; set; }
    public User Player { get; set; }
    public bool IsCaptain { get; set; }
}