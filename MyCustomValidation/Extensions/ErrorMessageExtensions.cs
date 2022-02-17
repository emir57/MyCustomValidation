using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class ErrorMessageExtensions
    {
        /// <summary>
        /// This method is custom error message
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject"></param>
        /// <param name="errorMessage">Custom Error Message</param>
        public static void ErrorMessage<TObject>(this TransferObject<TObject> transferObject, string errorMessage)
        {
            if (transferObject.ErrorMessage != null)
            {
                transferObject.ErrorMessage = errorMessage;
                ValidateExtensions.ValidationResults.Add(new ValidationResult
                { Message = transferObject.ErrorMessage });
            }
        }
        /// <summary>
        /// This method is default error message
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject"></param>
        public static void ErrorMessage<TObject>(this TransferObject<TObject> transferObject)
        {
            if (transferObject.ErrorMessage != null)
                ValidateExtensions.ValidationResults.Add(new ValidationResult
                { Message = transferObject.ErrorMessage });
        }
    }
}
