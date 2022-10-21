using StudentManagementSystem.Common.Models;
using StudentManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BusinessLogic.Contracts
{
    public interface IDepartmentsRepository : IGenericRepository<Department>
    {
        Task<DepartmentVM> GetDepartmentVM(int id);
        Task<List<DepartmentVM>?> GetDepartmentsVM();
        Task CreateDepartment(DepartmentVM departmentVM);
        Task UpdateDepartment(DepartmentVM departmentVM);
        Task<bool> DeleteDepartment(int Id);
    }
}
