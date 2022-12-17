using System.Collections;

namespace web_api.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CountryCode { get; set; }
    public bool Restricted { get; set; }
    
    public ICollection<Team> Teams { get; set; }
}