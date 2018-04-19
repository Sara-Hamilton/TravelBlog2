using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
       
        [Key]
        public int LocationId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        //public List<int> ExperienceId { get; set; }
        //public List<int> PersonId { get; set; }
        //public virtual List<Experience> Experiences { get; set; }
        //public virtual ICollection<Person> Persons { get; set; }
    }
}
