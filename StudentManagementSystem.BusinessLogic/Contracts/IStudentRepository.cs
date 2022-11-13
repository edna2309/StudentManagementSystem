using StudentManagementSystem.Common.Models;
using StudentManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BusinessLogic.Contracts
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        public Task<List<StudentVM>> GetStudentsVM();
        public Task<StudentVM> GetStudent();
    }
}
