using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;

namespace MyCustomValidation
{
    class ProductValidator : MyCustomValidator<Product>
    {
        public ProductValidator()
        {
            GetProp(p => p.ProductName).StartsWith("F");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product product = new Product
                {
                    ProductName = "Phone",
                    CategoryId = 5,
                    Stock = 2,
                    UnitPrice = 4999
                };
                new ValidationContext<object>(product,typeof(ProductValidator));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
