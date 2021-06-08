using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Masa";
            product.CategoryId = 2;
            product.UnitPrice = 500;
            product.UnitsInStock = 50;

            Product product2 = new Product {
            Id = 2,
            ProductName = "Sandalye",
            CategoryId = 3,
            UnitPrice = 600,
            UnitsInStock = 50
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);

        }
    }
}
