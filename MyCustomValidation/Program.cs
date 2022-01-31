using MyCustomValidation.Extensions;
using MyCustomValidation.Models;
using System;

namespace MyCustomValidation
{
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
                product.GetProp(p => p.CategoryId).MoreThan(4);
                product.GetProp(p => p.ProductName).StartsWith("P");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
