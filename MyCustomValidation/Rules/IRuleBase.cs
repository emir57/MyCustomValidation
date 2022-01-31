using MyCustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Rules
{
    public interface IRuleBase<TObject>
    {
        TransferObject<TObject> MinValue(TransferObject<TObject> transferObject, object minimumValue);
    }
}
