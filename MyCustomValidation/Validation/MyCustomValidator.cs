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
        public TObject _obj;
        protected ValidationResult ValidationResult = new ValidationResult();
        protected TransferObject<TObject> GetProp<TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propInfo = member.Member as PropertyInfo;
            var transferObject = new TransferObject<TObject>
            {
                Object = _obj,
                PropertyInfo = propInfo
            };
            return transferObject;
        }
        protected void Validate(TObject @object)
        {
            var type = this.GetType();
            _obj = @object;
            
        }
    }
}
