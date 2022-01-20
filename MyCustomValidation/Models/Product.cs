using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomValidation.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public byte Stock { get; set; }
    }
}
