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
        /// <summary>
        /// Select object field
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="obj">Anything Object</param>
        /// <param name="expression">LinQ Expression</param>
        /// <returns></returns>
        public static TransferObject<TObject> GetProp<TObject,TProperty>(this TObject obj,Expression<Func<TObject, TProperty>> expression)
        {
            var member = expression.Body as MemberExpression;
            var propInfo = member.Member as PropertyInfo;
            var transferObject = new TransferObject<TObject>
            {
                Object = obj,
                PropertyInfo = propInfo
            };
            return transferObject;
        }
    }
}
