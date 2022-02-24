using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Language
{
    public class EnglishLanguage : ILanguage
    {
        public string EndsWithMessage(string objectName, string endsWith)
        {
            string message = $"{objectName} is end with {endsWith}";
            return message;
        }

        public string MaxValueMessage(string objectName, object maximumValue)
        {
            string message = $"{objectName} is maximum could be {maximumValue}";
            return message;
        }

        public string MinValueMessage(string objectName, object minimumValue)
        {
            string message = $"{objectName} is minimum could be {minimumValue}";
            return message;
        }

        public string MoreThanMessage(string objectName, object moreThanValue)
        {
            string message = $"{objectName} is more than {moreThanValue}";
            return message;
        }

        public string MoreThanOrEqualToMessage(string objectName, object moreThanOrEqualTo)
        {
            string message = $"{objectName} is more than or equal to {moreThanOrEqualTo}";
            return message;
        }

        public string StartsWithMessage(string objectName, string startsWith)
        {
            string message = $"{objectName} is start with {startsWith}";
            return message;
        }
    }
}
