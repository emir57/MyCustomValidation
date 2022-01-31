using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Validation
{
    public abstract class MyCustomValidator<TObject>
        where TObject:class,new()
    {
        private TObject _obj = new TObject();
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
    }
}
