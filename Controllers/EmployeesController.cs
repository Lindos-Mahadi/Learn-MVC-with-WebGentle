﻿using System;
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
            
            return View();
        }

    }
}
