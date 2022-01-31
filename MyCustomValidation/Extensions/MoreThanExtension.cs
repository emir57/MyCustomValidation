using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class MoreThanExtension
    {
        /// <summary>
        /// more than
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="moreThanValue">more than value</param>
        public static TransferObject<TObject> MoreThan<TObject>(this TransferObject<TObject> transferObject, object moreThanValue)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(moreThanValue) >= Convert.ToInt64(value))
            {
                ValidateExtensions.ValidationResults.Add(new ValidationResult
                { Message = $"{objectName} is more than {moreThanValue}" });
            }
            return transferObject;
        }
    }
}
