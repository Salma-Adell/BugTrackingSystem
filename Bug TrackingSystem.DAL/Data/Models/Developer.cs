using System.ComponentModel.DataAnnotations.Schema;

namespace Bug_TrackingSystem.DAL.Data.Models;

public class Developer
{
    [ForeignKey("ApplicationUser")]
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    public Project? Project { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
}
