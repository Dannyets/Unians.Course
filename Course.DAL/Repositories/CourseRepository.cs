using BaseRepositories.EntityFrameworkCore.Repositories;
using Course.DAL.Interfaces;
using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.DAL.Repositories
{
    public class CourseRepository : BaseEntityFrameworkCoreRepository<CourseDbModel>, ICourseRepository
    {
        public CourseRepository(CourseDbContext dbContext) : base(dbContext)
        {

        }
    }
}
