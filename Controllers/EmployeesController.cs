using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApp_MVC_AllTopics_with_WebGentle.Models;

namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            ViewBag.MyName = "Lindos Mahadi";
            ViewBag.NameList = new List<string>() { "Lindos", "Mahadi", "Mizan" };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FullName = "Bill" },
                new Employee() { Id = 2, FullName = "Steve" },
                new Employee() { Id = 3, FullName = "Ram" },
                new Employee() { Id = 4, FullName = "Abdul" }
            };
            ViewBag.MyEmpList = employees;

            // VIEW DATA Start
            ViewData["MyName"] = "Lindos Mahadi view data";
            ViewData["NameList"] = new List<string>() { "Lindos", "Mahadi", "Mizan" };



            return View();
        }

    }
}
