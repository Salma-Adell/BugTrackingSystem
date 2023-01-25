using Microsoft.AspNetCore.Identity;
using Bug_TrackingSystem.DAL.EnumDataType;

namespace Bug_TrackingSystem.DAL.Data.Models;
//public enum Type
//{
//    Admin,
//    Manager,
//    Developer,
//    Tester
//}
public class ApplicationUser : IdentityUser<Guid>
{
    public string Name { get; set; } = string.Empty;
    public UserType Type { get; set; }
    public Admin? Admin { get; set; }
    public Manager? Manager { get; set; }
    public Developer? Developer { get; set; }
    public Tester? Tester { get; set; }

}
