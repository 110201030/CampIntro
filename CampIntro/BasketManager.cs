using System;
using System.Collections.Generic;
using System.Text;

namespace CampIntro
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi  " + product.Name);
        }

        public void AddAgain(string productName, string productDescription, double price)
        {
            Console.WriteLine("Eklendi "+ productName);
        }
    }
}
