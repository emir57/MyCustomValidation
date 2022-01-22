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
        public static void MinValue<TObject>(this TransferObject<TObject> transferObject ,Int64 minimumValue)
        {
            var value = transferObject.GetValue();
            if (Convert.ToInt64(value) < minimumValue)
            {
                throw new ValidateException($"{transferObject.PropertyInfo.Name} is minimum could be {minimumValue}");
            }
        }
    }
}
