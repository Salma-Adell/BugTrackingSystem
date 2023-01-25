using System.ComponentModel.DataAnnotations.Schema;

namespace Bug_TrackingSystem.DAL.Data.Models;
public class Tester
{
    [ForeignKey("ApplicationUser")]
    public Guid Id { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    public ApplicationUser? ApplicationUser { get; set; }

}
