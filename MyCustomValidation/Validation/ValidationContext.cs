using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext<TObject> : IValidationContext
        where TObject:class,new()
    {
        public List<ValidationResult> Errors { get; }
        public bool IsError { get; }
        public ValidationContext(TObject obj, Type myCustomValidator)
        {
            MyCustomValidator<TObject>._obj = obj;
            /*FieldInfo[] ps = myCustomValidator.GetFields();*/
            //var p = myCustomValidator.GetField("_obj");
            //if (p != null)
            //{
            //    var c = Activator.CreateInstance(myCustomValidator,obj);
            //    Type t = Nullable.GetUnderlyingType(p.FieldType) ?? p.FieldType;
            //    object safeValue = (obj == null) ? null : Convert.ChangeType(obj, t);
            //    p.SetValue(c, safeValue);
            //}
            Activator.CreateInstance(myCustomValidator);
            Errors = ValidateExtensions.ValidationResults;
            IsError = Errors.Count == 0 ? false : true;
            ValidateExtensions.ValidationResults = new List<ValidationResult>();
        }

    }
}
