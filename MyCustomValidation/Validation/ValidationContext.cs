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
            foreach (var error in ValidateExtensions.ValidationResults)
            {
                Console.WriteLine(error.Message);
            }
        }
        private bool isError = ValidateExtensions.ValidationResults.Count > 1 ? true : false;

        public bool IsError
        {
            get { return isError; }
            set { isError = value; }
        }

    }
}
