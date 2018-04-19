using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TravelBlog.Models;

namespace TravelBlog.Migrations
{
    [DbContext(typeof(TravelBlogDbContext))]
    [Migration("20180419184224_FixLocation")]
    partial class FixLocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.Property<DateTime>("TravelDate");

                    b.HasKey("ExperienceId");

                    b.HasIndex("LocationId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("TravelBlog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TravelBlog.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TravelBlog.Models.PersonExperience", b =>
                {
                    b.Property<int>("PersonExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExperiencesExperienceId");

                    b.Property<int?>("PersonsPersonId");

                    b.HasKey("PersonExperienceId");

                    b.HasIndex("ExperiencesExperienceId");

                    b.HasIndex("PersonsPersonId");

                    b.ToTable("PersonExperience");
                });

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.HasOne("TravelBlog.Models.Location", "Location")
                        .WithMany("Experiences")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("TravelBlog.Models.PersonExperience", b =>
                {
                    b.HasOne("TravelBlog.Models.Experience", "Experiences")
                        .WithMany("PersonExperiences")
                        .HasForeignKey("ExperiencesExperienceId");

                    b.HasOne("TravelBlog.Models.Person", "Persons")
                        .WithMany("PersonExperiences")
                        .HasForeignKey("PersonsPersonId");
                });
        }
    }
}
