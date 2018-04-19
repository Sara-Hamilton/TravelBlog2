using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Persons")]
    public class Person
    {
        public Person()
        {
            this.PersonExperiences = new HashSet<PersonExperience>();
        }

        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PersonExperience> PersonExperiences { get; set; }
    }
}
