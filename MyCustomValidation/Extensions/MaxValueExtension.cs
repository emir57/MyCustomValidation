using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class MaxValueExtension
    {
        /// <summary>
        /// is field maximum
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="maximumValue">maximum value</param>
        public static TransferObject<TObject> MaxValue<TObject>(this TransferObject<TObject> transferObject, object maximumValue)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(value) > Convert.ToInt64(maximumValue))
            {
                string message = ValidateSettings.Language.MaxValueMessage(objectName, maximumValue);
                transferObject.ErrorMessage(message);
            }
            return transferObject;
        }
    }
}
