using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_MVC_AllTopics_with_WebGentle.Models
{
    public class CustomValidations : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("lindos"))
                {
                    return  ValidationResult.Success;
                }
            }
            //ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field Must contain lindos";
            return new ValidationResult("This Field is contain lindos");
        }
    }
}