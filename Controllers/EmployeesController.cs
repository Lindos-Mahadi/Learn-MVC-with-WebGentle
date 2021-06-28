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
            Session.Abandon();
            TempData["MyName"] = "Temp Data From Index Method";
            return View();
        }
        // HTTP verbs  POST, GET, PUT, PATCH, and DELETE
        [HttpPost]
        [HttpGet]
        [HttpDelete]
        [HttpPut]
        [HttpHead]
        [HttpOptions]
        public ActionResult Index2()
        {
            ViewBag.MyName = TempData["MyName"];
            ViewBag.MyName = TempData.Peek("MyName");
            //TempData.Keep("MyName");
            return View();
        }
    }
}
