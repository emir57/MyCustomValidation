using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class EndsWithExtension
    {
        public static TransferObject<TObject> EndsWith<TObject>(this TransferObject<TObject> transferObject, string endsWith)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (!value.ToString().EndsWith(endsWith))
            {
                string message = ValidateSettings.Language.EndsWithMessage(objectName, endsWith);
                transferObject.ErrorMessage = message;
            }
            return transferObject;
        }
    }
}
