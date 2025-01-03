using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PR_WebApp.Models;
using PR_WebApp.Services;


namespace PR_WebApp.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly EmployeeService? _employeeService;
        private readonly DepartmentService? _departmentService;

        // add a constructor that initializes the _employeeService field with the employeeService parameter and the _departmentService field with the departmentService parameter.
        public EmployeeController(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/4
        public ActionResult Details(int id)
        {
            var employee = _employeeService?.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            var department = _departmentService?.Departments.FirstOrDefault(d => d.Id == employee.DepartmentId);

            var viewModel = new EmployeeDetailsViewModel
            {
                Employee = employee,
                Department = department
            };

            return View(viewModel);
        }


        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
    }
}
