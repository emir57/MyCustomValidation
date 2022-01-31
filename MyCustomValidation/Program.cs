
using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;

namespace MyCustomValidation
{
    class ProductValidator : MyCustomValidator<Product>
    {
        public ProductValidator(Product product):base(product)
        {
            GetProp(p => p.CategoryId).MinValue(2);
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
                    CategoryId = 1,
                    Stock = 2,
                    UnitPrice = 4999
                };
                ProductValidator productValidator = new ProductValidator(product);
                foreach (var error in ValidateExtensions.ValidationResults)
                {
                    Console.WriteLine(error.Message);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
