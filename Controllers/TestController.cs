using MyModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(EmployeeModel model)
        {
            //return View();
            string message = "SUCCESS";
            return Json(new { Message = message,  JsonRequestBehavior.AllowGet });
        }
    }
}