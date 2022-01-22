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
        /// <summary>
        /// is field minimum
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="minimumValue">minimum value</param>
        public static void MinValue<TObject>(this TransferObject<TObject> transferObject ,Int64 minimumValue)
        {
            var value = transferObject.GetValue();
            var objectName = transferObject.PropertyInfo.Name;
            if (Convert.ToInt64(value) < minimumValue)
            {
                throw new ValidateException($"{objectName} is minimum could be {minimumValue}");
            }
        }
        /// <summary>
        /// is field maximum
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="maximumValue">maximum value</param>
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
