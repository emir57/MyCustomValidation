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
        
        
        
        
        /// <summary>
        /// field is starts with
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject"></param>
        /// <param name="startsWith">startwith parameter</param>
        /// <returns></returns>
        public static TransferObject<TObject> StartsWith<TObject>(this TransferObject<TObject> transferObject,string startsWith)
        {
            object value;string objectName;
            GetProps(transferObject, out value, out objectName);
            if (!value.ToString().StartsWith(startsWith))
            {
                ValidationResults.Add(new ValidationResult 
                    { Message = $"{objectName} is start with {startsWith}" });
            }
            return transferObject;
        }
        public static void GetProps<TObject>(TransferObject<TObject> transferObject,out object value,out string objectName)
        {
            value = transferObject.GetValue();
            objectName = transferObject.PropertyInfo.Name;
        }
    }
}
