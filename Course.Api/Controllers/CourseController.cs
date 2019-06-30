using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using BaseRepositories.EntityFrameworkCore.Models.Interfaces;
using Course.Api.Models;
using Course.DAL.Interfaces;
using Course.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Api.Controllers
{
    public class CourseController : BaseEfCrudController<CourseApiModel, CourseDbModel>
    {
        private ICourseRepository _repository;

        public CourseController(ICourseRepository repository, 
                                IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
