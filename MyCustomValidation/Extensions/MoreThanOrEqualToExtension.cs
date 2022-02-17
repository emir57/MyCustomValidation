using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class MoreThanOrEqualToExtension
    {
        /// <summary>
        /// more than or equal to
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject">GetProp return value</param>
        /// <param name="moreThanOrEqualTo">more than or equal to</param>
        public static TransferObject<TObject> MoreThanOrEqualTo<TObject>(this TransferObject<TObject> transferObject, object moreThanOrEqualTo)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (Convert.ToInt64(moreThanOrEqualTo) > Convert.ToInt64(value))
            {
                string message = ValidateSettings.Language.MaxValueMessage(objectName, moreThanOrEqualTo);
                transferObject.ErrorMessage = message;
            }
            return transferObject;
        }
    }
}
