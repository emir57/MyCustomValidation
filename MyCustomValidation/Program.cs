
using MyCustomValidation.ExceptionClasses;
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
            GetProp(p => p.CategoryId).MinValue(3);
            GetProp(p => p.ProductName).StartsWith("F");
            GetProp(p => p.UnitPrice).MinValue(100);
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
                    CategoryId = 4,
                    Stock = 2,
                    UnitPrice = 1
                };
                Product product2 = new Product
                {
                    ProductName = "Phone",
                    CategoryId = 1,
                    Stock = 2,
                    UnitPrice = 4999
                };
                var result = new ValidationContext(product, typeof(ProductValidator));
                var result2 = new ValidationContext(product2, typeof(ProductValidator));
                if (result2.IsError)
                {
                    foreach (var error in result2.Errors)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                if (result.IsError)
                {
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
