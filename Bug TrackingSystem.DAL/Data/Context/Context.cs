using Bug_TrackingSystem.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bug_TrackingSystem.DAL.Data.Context;

public class Context : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public Context() { }
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<Admin> Admin { get; set; }
    public DbSet<Developer> Developer { get; set; }
    public DbSet<Manager> Manager { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Tester> Testers { get; set; }
    public DbSet<Ticket> Ticket { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.
            UseSqlServer("Data Source =.; Initial Catalog = Bug_TrackingSystem; Integrated Security = True; TrustServerCertificate=True;");
    }

}
