using AspNetCore.Infrastructure.Controllers;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Course.Api.Data.Models;
using Unians.Course.Data.Models;

namespace Unians.Course.Api.Controllers
{
    public class CourseController : BaseEfCrudController<ApiCourse, DbCourse>
    {
        public CourseController(IEfRepository<DbCourse> repository, 
                                IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
