using System.ComponentModel.DataAnnotations.Schema;

namespace Bug_TrackingSystem.DAL.Data.Models;

public class Manager
{
    [ForeignKey("ApplicationUser")]
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
}
