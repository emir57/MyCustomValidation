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
        public static void MinValue<TObject>(this TransferObject<TObject> transferObject ,object minimumValue)
        {
            var value = transferObject.GetValue();
            var objectName = transferObject.PropertyInfo.Name;
            if (Convert.ToInt64(value) < Convert.ToInt64(minimumValue))
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
        public static void MaxValue<TObject>(this TransferObject<TObject> transferObject,object maximumValue)
        {
            var value = transferObject.GetValue();
            var objectName = transferObject.PropertyInfo.Name;
            if (Convert.ToInt64(value) > Convert.ToInt64(maximumValue))
            {
                throw new ValidateException($"{objectName} is maximum could be {maximumValue}");
            }
        }
    }
}
