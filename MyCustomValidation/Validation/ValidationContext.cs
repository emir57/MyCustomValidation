using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext<TObject>
        where TObject:class,new()
    {

        //MyCustomValidator<TObject> _myCustomValidator;
        public TObject Entity { get; private set; }
        public ValidationContext(TObject obj,Type myCustomValidator)
        {
            var entityType
            //myCustomValidator.GetConstructors()[0].GetParameters().SetValue(obj,0);
            var validator = (MyCustomValidator<TObject>)Activator.CreateInstance(myCustomValidator,obj);
            
        }
    }
}
