using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unians.Course.Data.Models;

namespace Unians.Course.Data.Interfaces
{
    public interface ICourseRepository : IEfRepository<DbCourse>
    {
        Task<IEnumerable<DbCourse>> GetCoursesForFaculty(int facultyId);
    }
}
