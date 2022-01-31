using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Helpers.ObjectHelper;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class ValidateExtensions
    {
        public static List<ValidationResult> ValidationResults;
        static ValidateExtensions()
        {
            ValidationResults = new List<ValidationResult>();
        }
        public static void GetProps<TObject>(TransferObject<TObject> transferObject,out object value,out string objectName)
        {
            value = transferObject.GetValue();
            objectName = transferObject.PropertyInfo.Name;
        }
    }
}
