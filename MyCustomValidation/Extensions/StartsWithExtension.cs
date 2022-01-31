using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class StartsWithExtension
    {
        /// <summary>
        /// field is starts with
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="transferObject"></param>
        /// <param name="startsWith">startwith parameter</param>
        /// <returns></returns>
        public static TransferObject<TObject> StartsWith<TObject>(this TransferObject<TObject> transferObject, string startsWith)
        {
            object value; string objectName;
            ValidateExtensions.GetProps(transferObject, out value, out objectName);
            if (!value.ToString().StartsWith(startsWith))
            {
                ValidateExtensions.ValidationResults.Add(new ValidationResult
                { Message = $"{objectName} is start with {startsWith}" });
            }
            return transferObject;
        }
    }
}
