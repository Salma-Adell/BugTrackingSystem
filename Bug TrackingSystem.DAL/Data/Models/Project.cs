namespace Bug_TrackingSystem.DAL.Data.Models;
public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Manager? Manager { get; set; }
    public ICollection<Developer> Developers { get; set;} = new HashSet<Developer>();
    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
}
