using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Db.DbOperations;
using MyModels.Models;
using Newtonsoft.Json;

namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository=null;

        public HomeController()
        {
            repository = new EmployeeRepository();
        }
        public ActionResult Index()
        {
            var dataList = repository.GetAllEmployees();
            return View(dataList);
        }
        // Show ALL Data using JSON 
        public ActionResult getEmployee()
        {
            var dataList = JsonConvert.SerializeObject(repository.GetAllEmployees());
            return Json(dataList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddEmployee(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data Added";
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
         {
            var details = repository.GetDetailsEmployee(id);
            return View(details);
        }
        public ActionResult Edit(int id)
        {
            var details = repository.GetDetailsEmployee(id);
            return View(details);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                repository.UpdateEmployee(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            repository.DeleteEmployee(id);

            return RedirectToAction("Index");
        }
    }
}