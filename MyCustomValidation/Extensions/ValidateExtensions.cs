﻿using MyCustomValidation.ExceptionClasses;
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
        /// more than or equal to
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="moreThanOrEqualTo">more than or equal to</param>
        public static TransferObject<TObject> MoreThanOrEqualTo<TObject>(this TransferObject<TObject> transferObject,object moreThanOrEqualTo)
        {
            object value;string objectName;
            GetProps(transferObject, out value, out objectName);
            if(Convert.ToInt64(moreThanOrEqualTo) > Convert.ToInt64(value))
            {
                ValidationResults.Add(new ValidationResult 
                    { Message = $"{objectName} is more than or equal to {moreThanOrEqualTo}" });
            }
            return transferObject;
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
