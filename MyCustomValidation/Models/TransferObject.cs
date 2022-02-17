using System;
using System.Reflection;

namespace MyCustomValidation.Models
{
    public class TransferObject<TObject>
    {
        public TObject Object { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public string ErrorMessage { get; set; }
    }
}
