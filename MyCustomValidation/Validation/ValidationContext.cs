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

        public ValidationContext(object obj,Type myCustomValidator)
        {
            var baseType = myCustomValidator.BaseType;
            var entity = baseType.GetGenericArguments()[0];
            MyCustomValidator<TObject> validator = (MyCustomValidator<TObject>)Activator.CreateInstance(myCustomValidator,obj);
            
        }
    }
}
