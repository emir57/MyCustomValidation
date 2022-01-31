using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext : IValidationContext
    {
        public List<ValidationResult> Errors { get; }
        public bool IsError { get; }
        public ValidationContext(object obj, Type myCustomValidator)
        {
            Activator.CreateInstance(myCustomValidator, obj);
            Errors = ValidateExtensions.ValidationResults;
            IsError = Errors.Count == 0 ? false : true;
            ValidateExtensions.ValidationResults = new List<ValidationResult>();
        }

    }
}
