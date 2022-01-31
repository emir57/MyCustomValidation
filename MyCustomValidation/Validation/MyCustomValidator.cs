using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Helpers.ObjectHelper;
using MyCustomValidation.Models;
using MyCustomValidation.Rules;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public abstract class MyCustomValidator<TObject>:IValidator
        where TObject:class,new()
    {
        private TObject _obj;
        protected TransferObject<TObject> _transferObject;
        public MyCustomValidator(TObject @object)
        {
            _obj = @object;
        }
        protected TransferObject<TObject> GetProp<TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propInfo = member.Member as PropertyInfo;
            _transferObject = new TransferObject<TObject>
            {
                Object = _obj,
                PropertyInfo = propInfo
            };
            return _transferObject;
        }
        
    }
}
