using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_TrackingSystem.DAL.Data.Models
{
    internal class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Manager Manager { get; set; }
        public List<Developer> Developers { get; set;}
        public List<Ticket> Tickets { get; set; }
    }
}
