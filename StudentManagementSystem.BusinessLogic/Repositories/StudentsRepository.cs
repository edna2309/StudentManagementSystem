using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.BusinessLogic.Contracts;
using StudentManagementSystem.Common.Models;
using StudentManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BusinessLogic.Repositories
{
    public class StudentsRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public StudentsRepository(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task<List<StudentVM>> GetStudentsVM()
        {
            try
            {
                var students = await applicationDbContext.Students.ToListAsync();
                return mapper.Map<List<StudentVM>>(students);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Task<StudentVM> GetStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateStudent(StudentVM studentVM)
        {
            if(studentVM != null)
            {
                var student = mapper.Map<Student>(studentVM);
                await applicationDbContext.AddAsync(student);

                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
