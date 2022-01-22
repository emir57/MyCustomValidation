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
        public static void MinValue<TObject>(this TransferObject<TObject> transferObject ,Int64 minimumValue)
        {
            var value = transferObject.GetValue();
            var objectName = transferObject.PropertyInfo.Name;
            if (Convert.ToInt64(value) < minimumValue)
            {
                throw new ValidateException($"{objectName} is minimum could be {minimumValue}");
            }
        }
        public static void MaxValue<TObject>(this TransferObject<TObject> transferObject,Int64 maximumValue)
        {
            var value = transferObject.GetValue();
            var objectName = transferObject.PropertyInfo.Name;
            if (Convert.ToInt64(value) > maximumValue)
            {
                throw new ValidateException($"{objectName} is maximum could be {maximumValue}");
            }
        }
    }
}
