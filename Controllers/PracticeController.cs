using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public string Index()
        {
            return "Practice Controller";
        }
        public string Name()
        {
            return "Hello Lindos Mahadi";
        }
        public string Profile(int id)
        {
            string profile = string.Empty;
            if (id == 1)
            {
                profile = "Profile ID is 1";
            }
            else if (id == 2)
            {
                profile = "Profile ID is 2";
            }
            else if (id == 3)
            {
                profile = "Profile ID is 3";
            }
            return profile;
        }
        public string Address( int id, string department)
        {
            return "id = " + id +" "+ "Department =" + department;
        }
    }
}