using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_MVC_AllTopics_with_WebGentle.Models;


namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string StudentName(string firstName, string lastName)
        {
            return "Form Parameters-" +firstName + ", "+ lastName ;
        }
    }
}
