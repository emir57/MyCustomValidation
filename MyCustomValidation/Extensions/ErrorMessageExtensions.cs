using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class ErrorMessageExtensions
    {
        public static void ErrorMessage<TObject>(this TransferObject<TObject> transferObject, string errorMessage)
        {

        }
    }
}
