using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_AllTopics_with_WebGentle.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage ="Please enter Name")]
        [CustomValidations(ErrorMessage = "write something")]
        //[CustomValidations]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Please enter Standard Name")]
        public string Standard { get; set; }

        public StudentAddress StudentAddress { get; set; }
    }
}