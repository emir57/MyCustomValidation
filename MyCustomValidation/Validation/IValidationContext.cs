using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Validation
{
    public interface IValidationContext
    {
        List<ValidationResult> Errors { get; }
        bool IsError { get; }
    }
}
