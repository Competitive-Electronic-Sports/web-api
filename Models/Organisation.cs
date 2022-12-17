namespace web_api.Models;

public class Organisation
{
    public ICollection<Event> Events { get; set; }
}