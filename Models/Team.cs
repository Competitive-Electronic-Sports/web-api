namespace web_api.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    
    public ICollection<TeamMember> TeamMembers { get; set; }
}