using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.BusinessLogic.Contracts;
using StudentManagementSystem.Common.Constants;
using StudentManagementSystem.Common.Models;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Web.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin + "," + Roles.SystemManager)]
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsRepository departmentsRepository;

        public DepartmentsController(IDepartmentsRepository departmentsRepository)
        {
            this.departmentsRepository = departmentsRepository;
        }
        // GET: DepartmentsController
        public async Task<ActionResult> Index()
        {
            return View(await departmentsRepository.GetDepartmentsVM());
        }

        // GET: DepartmentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentsController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: DepartmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    departmentsRepository.CreateDepartment(model);
                    return RedirectToAction(nameof(Index));

                }
                return View(model);
            }
            catch(Exception ex)
            {

                return View();
            }
        }

        // GET: DepartmentsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            DepartmentVM departmentsVM = await departmentsRepository.GetDepartmentVM(id);
            return View(departmentsVM);
        }

        // POST: DepartmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(DepartmentVM departmentVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await departmentsRepository.UpdateDepartment(departmentVM);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, "All required fields should be populated.");
                return View(departmentVM);

            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentsController/Delete/5
        public async Task<ActionResult> Delete()
        {
            return View();
        }

        // POST: DepartmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        public async Task<ActionResult> Delete([Bind("#confirm")] string confirm, int Id)
        {
            try
            {
                if (confirm == "Yes")
                {
                    await departmentsRepository.DeleteDepartment(Id);
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }
    }
}
