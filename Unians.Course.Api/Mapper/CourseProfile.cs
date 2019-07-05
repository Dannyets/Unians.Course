using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.Course.Api.Data.Models;
using Unians.Course.Data.Models;

namespace Unians.Course.Api.Mapper
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<ApiCourse, DbCourse>().ReverseMap();
        }
    }
}
