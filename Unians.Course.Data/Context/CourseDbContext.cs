using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        public DbSet<DbCourse> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbCourse>().HasKey(p => p.Id);

            modelBuilder.Entity<DbCourse>().HasIndex(p => p.FacultyId);

            //TODO: REMOVE ONCE NEW DATABASE IS ADDED
            AddInitialData(modelBuilder);
        }

        private void AddInitialData(ModelBuilder modelBuilder)
        {
            var courses = new List<DbCourse>
            {
                new DbCourse
                {
                    Id = 1,
                    FacultyId = 1,
                    CourseNumber = "03455567",
                    Name = "מבוא למדעי המחשב",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow
                },
                new DbCourse
                {
                    Id = 2,
                    FacultyId = 1,
                    CourseNumber = "234218",
                    Name = "מבני נתונים 1",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow
                },
                new DbCourse
                {
                    Id = 1,
                    FacultyId = 1,
                    CourseNumber = "234247",
                    Name = "אלגוריתמים 1",
                    CreatedAt = DateTime.UtcNow,
                    LastUdpatedAt = DateTime.UtcNow
                }
            };

            modelBuilder.Entity<DbCourse>().HasData(courses);
        }

    }
}
