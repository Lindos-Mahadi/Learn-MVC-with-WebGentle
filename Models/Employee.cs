using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_AllTopics_with_WebGentle.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name ="Email")]
        [HiddenInput(DisplayValue = false)]
        public string EmailAddress { get; set; }

        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }
        [DisplayAttribute(Name = "Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }
    }

}