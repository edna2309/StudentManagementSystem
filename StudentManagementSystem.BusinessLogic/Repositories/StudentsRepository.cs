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

        public StudentsRepository(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = applicationDbContext.Users.AllAsync(user => user is Student);

            throw new NotImplementedException();
        }

        public Task<StudentVM> GetStudent()
        {
            throw new NotImplementedException();
        }
    }
}
