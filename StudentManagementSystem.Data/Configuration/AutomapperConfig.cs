using AutoMapper;
using StudentManagementSystem.Common.Models;

namespace StudentManagementSystem.Data.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Department, DepartmentVM>().ReverseMap();
            CreateMap<Student, StudentVM>().ReverseMap();
        }
    }
}
