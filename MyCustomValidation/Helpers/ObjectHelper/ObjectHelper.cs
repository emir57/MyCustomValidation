using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Helpers.ObjectHelper
{
    public static class ObjectHelper
    {
        public static object GetValue<TObject>(this TransferObject<TObject> transferObject)
        {
            return transferObject.PropertyInfo.GetValue(transferObject.Object, null);
        }
    }
}
