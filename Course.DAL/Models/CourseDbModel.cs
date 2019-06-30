using BaseRepositories.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.DAL.Models
{
    public class CourseDbModel : BaseEntity
    {
        public string Name { get; set; }

        public int FacultyId { get; set; }
    }
}
