using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Gökhan");
            myList.Add("Gökhan2");

            foreach (string item in myList.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
