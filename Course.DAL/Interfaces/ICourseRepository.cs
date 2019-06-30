using BaseRepositories.EntityFrameworkCore.Models.Interfaces;
using Course.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.DAL.Interfaces
{
    public interface ICourseRepository : IEfRepository<CourseDbModel>
    {
    }
}
