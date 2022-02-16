using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Language
{
    public class TurkishLanguage : ILanguage
    {
        public string MaxValueMessage(string objectName, object maximumValue)
        {
            string message = $"{objectName} alanı en fazla {maximumValue} değerinde olabilir";
            return message;
        }

        public string MinValueMessage(string objectName, object minimumValue)
        {
            string message = $"{objectName} alanı en az {minimumValue} değerinde olabilir";
            return message;

        }

        public string MoreThanMessage(string objectName, object moreThanValue)
        {
            string message = $"{objectName} alanı {moreThanValue} değerinden büyük olmalıdır";
            return message;
        }

        public string MoreThanOrEqualToMessage(string objectName, object moreThanOrEqualTo)
        {
            string message = $"{objectName} alanı {moreThanOrEqualTo} değerinden büyük veya eşit olmalıdır";
            return message;
        }

        public string StartsWithMessage(string objectName, string startsWith)
        {
            string message = $"{objectName} alanı '{startsWith}' ile başlamalıdır";
            return message;
        }
    }
}
