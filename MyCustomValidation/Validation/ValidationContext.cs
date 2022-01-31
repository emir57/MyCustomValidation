using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext
    {
        public ValidationContext(object obj, Type myCustomValidator)
        {
            var validator = Activator.CreateInstance(myCustomValidator, obj);
            errors = ValidateExtensions.ValidationResults;
            isError = errors.Count == 0 ? false : true;
            ValidateExtensions.ValidationResults = new List<ValidationResult>();
        }
        private List<ValidationResult> errors;

        public List<ValidationResult> Errors
        {
            get 
            {
                return errors; 
            }
        }

        private bool isError;

        public bool IsError
        {
            get { return isError; }
        }

    }
}
