using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class FiltersController : Controller
    {
        // GET: Filters
        public ActionResult Index()
        {
            return View();
        }

        // OUTPUT CACH FILER
        [OutputCache(Duration = 20)] // duration always works in second
        public ActionResult GetDate()
        {
            return View();
        }
    }
}