using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_TrackingSystem.DAL.Data.Models
{
    internal class Manager
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
