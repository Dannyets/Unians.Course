using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unians.Course.Data.Models
{
    public class DbCourse : DbIdEntity
    {
        public string CourseNumber { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }
    }
}
