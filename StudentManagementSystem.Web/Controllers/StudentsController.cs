using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.BusinessLogic.Contracts;
using StudentManagementSystem.Common.Constants;
using StudentManagementSystem.Common.Models;

namespace StudentManagementSystem.Web.Controllers
{
    [Authorize(Roles = Roles.SuperAdmin + "," + Roles.SystemManager)]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IDepartmentsRepository departmentsRepository;

        public StudentsController(IStudentRepository studentRepository, IDepartmentsRepository departmentsRepository)
        {
            this.studentRepository = studentRepository;
            this.departmentsRepository = departmentsRepository;
        }
        // GET: StudentsController
        public async Task<ActionResult> Index()
        {
            return View(await studentRepository.GetStudentsVM());
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudendtsController/Create
        public async Task<ActionResult> Create()
        {
            await PopulateDepartments();
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(StudentVM student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!await studentRepository.CreateStudent(student))
                    {
                        ModelState.AddModelError(string.Empty, "The student was not created successfully.");
                    }
                     return RedirectToAction(nameof(Index));

                }
                else
                {
                    return View();
                }
            }
            catch
            {
                await PopulateDepartments();
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task PopulateDepartments()
        {
            List<DepartmentVM>? departments = await departmentsRepository.GetDepartmentsVM();
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
        }
    }
}
