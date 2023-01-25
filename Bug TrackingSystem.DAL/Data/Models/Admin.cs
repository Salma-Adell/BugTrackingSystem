using System.ComponentModel.DataAnnotations.Schema;

namespace Bug_TrackingSystem.DAL.Data.Models;

public class Admin
{
    [ForeignKey("ApplicationUser")]
    public Guid Id { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }

}
