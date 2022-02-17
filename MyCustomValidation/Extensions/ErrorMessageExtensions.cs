using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class ErrorMessageExtensions
    {
        public static void ErrorMessage<TObject>(this TransferObject<TObject> transferObject, string errorMessage)
        {
            transferObject.ErrorMessage = errorMessage;
            ValidateExtensions.ValidationResults.Add(new ValidationResult
            { Message = transferObject.ErrorMessage });
        }
        public static void ErrorMessage<TObject>(this TransferObject<TObject> transferObject)
        {
            ValidateExtensions.ValidationResults.Add(new ValidationResult
            { Message = transferObject.ErrorMessage });
        }
    }
}
