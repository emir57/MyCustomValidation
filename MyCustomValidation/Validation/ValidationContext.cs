using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext : IValidationContext
    {
        public List<ValidationResult> Errors { get; private set; }
        public bool IsError { get; private set; }
        //public ValidationContext(TObject obj, Type myCustomValidator)
        //{
        //    Type s = myCustomValidator.BaseType.GetGenericArguments()[0];
        //    MyCustomValidator<TObject>._obj = (Product)Convert.ChangeType(obj, s);
        //    /*FieldInfo[] ps = myCustomValidator.GetFields();*/
        //    //var p = myCustomValidator.GetField("_obj");
        //    //if (p != null)
        //    //{
        //    //    var c = Activator.CreateInstance(myCustomValidator,obj);
        //    //    Type t = Nullable.GetUnderlyingType(p.FieldType) ?? p.FieldType;
        //    //    object safeValue = (obj == null) ? null : Convert.ChangeType(obj, t);
        //    //    p.SetValue(c, safeValue);
        //    //}
        //    Activator.CreateInstance(myCustomValidator);
        //    Errors = ValidateExtensions.ValidationResults;
        //    IsError = Errors.Count == 0 ? false : true;
        //    ValidateExtensions.ValidationResults = new List<ValidationResult>();
        //}
        public IValidationContext Validate<TObject>(TObject obj, Type myCustomValidator)
            where TObject:class,new()
        {
            Type s = myCustomValidator.BaseType.GetGenericArguments()[0];
            MyCustomValidator<TObject>._obj = obj;

            Activator.CreateInstance(myCustomValidator);
            Errors = ValidateExtensions.ValidationResults;
            IsError = Errors.Count == 0 ? false : true;
            ValidateExtensions.ValidationResults = new List<ValidationResult>();
            return this;
        }

    }
}
