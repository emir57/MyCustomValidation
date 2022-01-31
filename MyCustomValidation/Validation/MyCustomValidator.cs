using MyCustomValidation.Models;
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
        public ValidationContext<TObject> _validationContext;
        protected TransferObject<TObject> GetProp<TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propInfo = member.Member as PropertyInfo;
            var transferObject = new TransferObject<TObject>
            {
                Object = _validationContext.Entity,
                PropertyInfo = propInfo
            };
            return transferObject;
        }
    }
}
