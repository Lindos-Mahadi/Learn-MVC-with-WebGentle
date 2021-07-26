using MyModels.Models;
using Newtonsoft.Json;
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

        public JsonResult About()
        {
            List<string> countries = new List<string>()
            {
                "Afghanistan"
                ,"Albania"
                ,"Algeria"
                ,"Andorra"
                ,"Angola"
                ,"Antigua and Barbuda"
                ,"Argentina"
                ,"Armenia"
                ,"Australia"
                ,"Austria"
                ,"Austrian Empire"
                ,"Azerbaijan"
            }; 
            var json = JsonConvert.SerializeObject(countries);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Learn()
        {
            List<string> countries = new List<string>()
            {
                "Cabo Verde"
                ,"Cambodia"
                ,"Cameroon"
                ,"Canada"
                ,"Cayman Islands"
                ,"Central African Republic"
                ,"Central American Federation"
                ,"Chad"
                ,"Chile"
                ,"China"
                ,"Colombia"
                ,"Comoros"
                ,"Congo Free State"
                ,"Costa Rica"
                ,"Cote d’Ivoire (Ivory Coast)"
                ,"Croatia"
                ,"Cuba"
                ,"Cyprus"
                ,"Czechia"
                ,"Czechoslovakia"
            };
            var json = JsonConvert.SerializeObject(countries);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}