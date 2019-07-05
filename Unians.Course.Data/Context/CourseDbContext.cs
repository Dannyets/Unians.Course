using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Unians.Course.Data.Models;

namespace Unians.Course.Data.Context
{
    public class CourseDbContext : BaseMySqlDbContext
    {
        public CourseDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            optionsBuilder.UseInMemoryDatabase("unians_course");
        }

        public DbSet<DbCourse> Faculties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbCourse>().HasKey(p => p.Id);

            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            AddInitialData(modelBuilder);
        }

        private void AddInitialData(ModelBuilder modelBuilder)
        {
            var course = new DbCourse
            {
                Id = 1,
                FacultyId = 1,
                CourseNumber = "03455567",
                Name = "מבוא למדעי המחשב",
                CreatedAt = DateTime.UtcNow,
                LastUdpatedAt = DateTime.UtcNow
            };

            var courses = new List<DbCourse> { course };

            modelBuilder.Entity<DbCourse>().HasData(courses);
        }

    }
}
