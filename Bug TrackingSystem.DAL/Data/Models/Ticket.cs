using Bug_TrackingSystem.DAL.EnumDataType;

namespace Bug_TrackingSystem.DAL.Data.Models;
public class Ticket
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Priority { get; set; }
    public Status Status { get; set; }
    public Guid ProjectId { get; set; }
    public Guid DeveloperId { get; set; }
    public Guid TesterId { get; set; }
    public Tester? Tester { get; set; }
    public Developer? Developer { get; set; }
    public Project? Project { get; set; }

}
