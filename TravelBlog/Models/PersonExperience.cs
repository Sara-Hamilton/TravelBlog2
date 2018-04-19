using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("PersonExperience")]
    public class PersonExperience
    {
        public PersonExperience()
        {
        }

        [Key]
        public int PersonExperienceId { get; set; }
        public int PersonId { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
        public virtual Person Person { get; set; }
    }
}
