using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 10;
            var dortIslem = new DortIslem();
            dortIslem.Topla(sayi1,sayi2);
            dortIslem.Topla(100, 200);
            Console.WriteLine("Hello World!");
        }
    }
}
