using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class MinValueExtension
    {
        /// <summary>
        /// is field minimum
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="minimumValue">minimum value</param>
        public static TransferObject<TObject> MinValue<TObject>(this TransferObject<TObject> transferObject, object minimumValue)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(value) < Convert.ToInt64(minimumValue))
            {
                ValidateExtensions.ValidationResults.Add(new ValidationResult
                { Message = $"{objectName} is minimum could be {minimumValue}" });
            }
            return transferObject;
        }
    }
}
