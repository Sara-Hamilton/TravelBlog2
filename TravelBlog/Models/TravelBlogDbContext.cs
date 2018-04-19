using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonExperience> PersonExperiences { get; set; }

        public TravelBlogDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseMySql(@"Server=localhost;Port=8889;database=travelblogAndy;uid=root;pwd=root;");
        
        public TravelBlogDbContext(DbContextOptions<TravelBlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
