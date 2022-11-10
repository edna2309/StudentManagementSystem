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
    public class DepartmentsRepository : GenericRepository<Department>, IDepartmentsRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public DepartmentsRepository(ApplicationDbContext applicationDbContext, IMapper mapper) : base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task CreateDepartment(DepartmentVM departmentVM)
        {
            var department = mapper.Map<Department>(departmentVM);
            await applicationDbContext.AddAsync(department);

            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteDepartment(int Id)
        {
            Department department = await applicationDbContext.Departments.FindAsync(Id);
            if(department == null)
            {
                return false;
            }
            applicationDbContext.Departments.Remove(department);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<DepartmentVM>?> GetDepartmentsVM()
        {
            try
            {
                var departments = await applicationDbContext.Departments.ToListAsync();
                return mapper.Map<List<DepartmentVM>>(departments);
            }
            catch 
            {
                
                return null;
            }
           
        }

        public async Task<DepartmentVM> GetDepartmentVM(int id)
        {
            var department = await applicationDbContext.Departments.FirstOrDefaultAsync(department => department.Id == id);

            var deparmentVM = mapper.Map<DepartmentVM?>(department);
            if (deparmentVM == null)
            {
                return null;
            }
            else
            {
                return deparmentVM;
            }
        }

        public async Task UpdateDepartment(DepartmentVM departmentVM)
        {
            var department = await applicationDbContext.Departments.FirstOrDefaultAsync(department => department.Id == departmentVM.Id);
            if(department == null)
            {
                return;
            }
            department.SetInfo(departmentVM.Name, departmentVM.Description);
            applicationDbContext.Entry(department).State = EntityState.Modified;
            applicationDbContext.Update(department);
            await applicationDbContext.SaveChangesAsync();
            
        }
    }
}
