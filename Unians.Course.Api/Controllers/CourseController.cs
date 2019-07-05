using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Course.Api.Data.Models;
using Unians.Course.Data.Interfaces;
using Unians.Course.Data.Models;

namespace Unians.Course.Api.Controllers
{
    public class CourseController : BaseEfCrudController<ApiCourse, DbCourse>
    {
        private ICourseRepository _repository;

        public CourseController(ICourseRepository repository, 
                                IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<ApiCourse>> GetCoursesForFaculty(int facultyId)
        {
            var dbCourses =  await _repository.GetCoursesForFaculty(facultyId);

            var apiCourses = dbCourses.Select(c => _mapper.Map<ApiCourse>(c));

            return apiCourses;
        }
    }
}
