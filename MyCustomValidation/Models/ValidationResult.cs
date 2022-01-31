using MyCustomValidation.ExceptionClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Models
{
    public class ValidationResult
    {
        public List<ValidateException> ValidateExceptions { get; set; }
    }
}
