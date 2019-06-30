using BaseRepositories.EntityFrameworkCore.MySql;
using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.DAL
{
    public class CourseDbContext : BaseMySqlDbContext
    {
        public DbSet<CourseDbModel> Courses { get; set; }

        public CourseDbContext(IConfiguration configuration) : base(configuration)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseDbModel>().HasKey(p => p.Id);
        }
    }
}
