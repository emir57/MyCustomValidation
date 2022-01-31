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
        private TObject _obj;
        public MyCustomValidator(TObject obj):this()
        {
            _obj = obj;
        }
        public MyCustomValidator()
        {

        }
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
