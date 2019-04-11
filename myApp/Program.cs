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
            /*
            var names = new List<string> {"Pedro", "Anny"};
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            //names.Remove("");
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            string value = $"I've added {names[2]} and {names[3]} to the list.";
            Console.WriteLine(value);

            value = $"The list has {names.Count} people in it";
            Console.WriteLine(value);

            var index = names.IndexOf("Bill");
            if (index != -1)
            Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
            Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            index = names.IndexOf("Bill");
            if (index != -1)
            Console.WriteLine($"The name {names[index]} is at index {index}");

            */

            var fibonacciNumbers = new List<int> {1, 1};
            
            var end = 20;

            for(int i = 3; i <= end; i++){
              var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
              var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];  
              fibonacciNumbers.Add(previous + previous2);                        
            } 

            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);    
        }
    }
}
