using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.ExceptionClasses
{
    public class ValidateException:Exception
    {
        public ValidateException(string message):base("Validate Exception: "+message)
        {

        }
    }
}
