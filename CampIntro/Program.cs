using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            BasketManager basketManager = new BasketManager();
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Elma açıklaması";
            product1.StockQuantity = 50;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 25;
            product2.Description = "Karpuz açıklaması";
            product2.StockQuantity = 100;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name +" "+product.Price+" "+product.Description);
                basketManager.Add(product);
                basketManager.AddAgain(product.Name, product.Description, product.Price);
            }            
        }
    }
}
