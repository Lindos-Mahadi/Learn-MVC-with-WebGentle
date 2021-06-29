using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MVC_AllTopics_with_WebGentle.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Standard { get; set; }

        public StudentAddress StudentAddress { get; set; }
    }
}