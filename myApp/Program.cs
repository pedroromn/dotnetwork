using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            var names = new List<string> {"Pedro", "Anny"};
            foreach (string name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
