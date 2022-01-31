using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Validation
{
    public class ValidationContext<TObject>
        where TObject:class,new()
    {

        //MyCustomValidator<TObject> _myCustomValidator;
        public TObject Entity { get; private set; }
        public ValidationContext(object obj,Type myCustomValidator)
        {
            Entity = (TObject)obj;
            var baseType = myCustomValidator.BaseType;
            var entity = baseType.GetGenericArguments()[0];
            MyCustomValidator<TObject> validator = (MyCustomValidator<TObject>)Activator.CreateInstance(myCustomValidator);
            validator._validationContext = this;
        }
    }
}
