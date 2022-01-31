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
            object value;string objectName;
            GetProps(transferObject, out value, out objectName);
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
            object value; string objectName;
            GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(value) > Convert.ToInt64(maximumValue))
            {
                throw new ValidateException($"{objectName} is maximum could be {maximumValue}");
            }
        }
        /// <summary>
        /// more than
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="moreThanValue">more than value</param>
        public static TransferObject<TObject> MoreThan<TObject>(this TransferObject<TObject> transferObject,object moreThanValue)
        {
            object value; string objectName;
            GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(moreThanValue) >= Convert.ToInt64(value))
            {
                throw new ValidateException($"{objectName} is more than {moreThanValue}");
            }
            return transferObject;
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
                throw new ValidateException($"{objectName} is more than or equal to {moreThanOrEqualTo}");
            }
            return transferObject;
        }

        private static void GetProps<TObject>(TransferObject<TObject> transferObject,out object value,out string objectName)
        {
            value = transferObject.GetValue();
            objectName = transferObject.PropertyInfo.Name;
        }
    }
}
