using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace Unians.Course.Data.Models
{
    public class DbCourse : DbIdEntity
    {
        public string CourseNumber { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }
    }
}
