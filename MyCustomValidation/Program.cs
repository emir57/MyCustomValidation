
using MyCustomValidation.ExceptionClasses;
using MyCustomValidation.Extensions;
using MyCustomValidation.Language;
using MyCustomValidation.Models;
using MyCustomValidation.Validation;
using System;
using System.Collections.Generic;

namespace MyCustomValidation
{
    class ProductValidator : MyCustomValidator<Product>
    {
        public ProductValidator()
        {
            GetProp(p => p.CategoryId).MinValue(3).ErrorMessage();
            GetProp(p => p.ProductName).StartsWith("F").ErrorMessage();
            GetProp(p => p.UnitPrice).MaxValue(55).ErrorMessage("maksimum değer 55 olabilir");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValidateSettings.Language = new TurkishLanguage();
            try
            {
                Product product1 = new Product
                {
                    ProductName = "FPhone",
                    CategoryId = 4,
                    Stock = 2,
                    UnitPrice = 66
                };
                Product product2 = new Product
                {
                    ProductName = "Phone",
                    CategoryId = 3,
                    Stock = 2,
                    UnitPrice = 4999
                };
                var products = new List<Product>() { product1, product2 };
                var context = new ValidationContext();
                foreach (var product in products)
                {
                    var result = context.Validate(product, typeof(ProductValidator));
                    if (result.IsError)
                    {
                        foreach (var error in result.Errors)
                        {
                            Console.WriteLine(error.Message);
                        }
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
