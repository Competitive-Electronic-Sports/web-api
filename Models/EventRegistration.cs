namespace web_api.Models;

public class EventRegistration
{
    public int Id { get; set; }
    public Team Team { get; set; }
    public Event Event { get; set; }
    public DateTime Timestamp { get; set; }
    public bool Approved { get; set; }
}