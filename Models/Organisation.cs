namespace web_api.Models;

public class Organisation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Created { get; set; }
    public ICollection<Event>? Events { get; set; }
}