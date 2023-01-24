using Bug_TrackingSystem.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_TrackingSystem.DAL.Data.Context
{
    internal class Context : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Developer> Developers { get; set; }
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
}
