using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Extensions
{
    public static class ValidateExtensions
    {
        public static void MinValue(this Int64 value ,Int64 minimumValue)
        {
            if (value < minimumValue)
            {
                throw new Exception($"{value} is minimum {minimumValue}");
            }
        }
    }
}
