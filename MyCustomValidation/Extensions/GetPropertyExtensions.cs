using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class GetPropertyExtensions
    {
        public static TProperty GetProp<TMethod,TProperty>(this TMethod obj,Expression<Func<TMethod,TProperty>> expression)
        {

        }
    }
}
