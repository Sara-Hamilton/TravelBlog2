using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        public Experience()
        {
        }
        [Key]
        public int ExperienceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime TravelDate { get; set; }
        public List<int> PersonId { get; set; }
        public List<int> LocationId { get; set; }
    }
}
