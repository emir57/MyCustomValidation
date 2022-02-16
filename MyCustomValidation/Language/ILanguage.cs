using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Language
{
    public interface ILanguage
    {
        string MaxValueMessage(string objectName, object maximumValue);
        string MinValueMessage(string objectName, object minimumValue);
        string MoreThanMessage(string objectName, object moreThanValue);
        string MoreThanOrEqualToMessage(string objectName, object moreThanOrEqualTo);
        string StartsWithMessage(string objectName, string startsWith);
    }
}
