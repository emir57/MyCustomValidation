using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Language
{
    public class EnglishLanguage : ILanguage
    {
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
            throw new NotImplementedException();
        }

        public string MoreThanOrEqualToMessage(string objectName, object moreThanOrEqualTo)
        {
            throw new NotImplementedException();
        }

        public string StartsWithMessage(string objectName, string startsWith)
        {
            throw new NotImplementedException();
        }
    }
}
