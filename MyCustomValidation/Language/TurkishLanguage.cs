using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Language
{
    public class TurkishLanguage : ILanguage
    {
        public string MaxValueMessage(string objectName, object maximumValue)
        {
            throw new NotImplementedException();
        }

        public string MinValueMessage(string objectName, object minimumValue)
        {
            throw new NotImplementedException();
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
