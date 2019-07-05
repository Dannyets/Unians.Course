using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Course.Data.Interfaces;
using Unians.Course.Data.Models;

namespace Unians.Course.Data.Repositories
{
    public class CourseRepository : BaseEntityFrameworkCoreRepository<DbCourse>, ICourseRepository
    {
        public CourseRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<DbCourse>> GetCoursesForFaculty(int facultyId)
        {
            return await _dbSet.Where(c => c.FacultyId == facultyId).ToListAsync();
        }
    }
}
