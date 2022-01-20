using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class GetPropertyExtensions
    {
        public static TransferObject<TObject> GetProp<TObject,TProperty>(this TObject obj,Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propInfo = member.Member as PropertyInfo;
            var value = (TProperty)propInfo.GetValue(obj, null);
            Console.WriteLine(expression.Body);
            return new TransferObject<TObject>
            {
                Object = obj,
                PropertyInfo=propInfo
            };
        }
    }
}
