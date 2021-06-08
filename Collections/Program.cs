using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> {"a","b","c","d"};
            isimler.Add("f");
            foreach (var isim in isimler)
            {                
                Console.WriteLine(isim);
            }
        }
    }
}
