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
            //var students = await applicationDbContext.Users.AllAsync(user => user is Student);
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
    }
}
