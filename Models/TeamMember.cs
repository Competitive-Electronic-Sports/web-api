namespace web_api.Models;

public class TeamMember
{
    public Team Team { get; set; }
    public User Player { get; set; }
    public bool IsCaptain { get; set; }
}