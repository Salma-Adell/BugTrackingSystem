using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_TrackingSystem.DAL.Data.Models
{
    internal class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }

        [ForeignKey("Developer")]
        public string DeveloperId { get; set; }
        
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        
        [ForeignKey("Tester")]
        public string TesterId { get; set; }
        public virtual Tester Tester { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }
        
    }
}
