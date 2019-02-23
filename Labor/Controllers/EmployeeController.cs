using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core;
using Facade;
using Infra;

namespace Labor.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SalesDbContext db;
        public EmployeeController(SalesDbContext db) { this.db = db; }
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            var employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }
            model.Employees = list;
            return View("Index", model);
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
        public string SaveEmployee(Employee e)
        {
            return e.FirstName + "|" + e.LastName + "|" + e.Salary;
        }
    }
}