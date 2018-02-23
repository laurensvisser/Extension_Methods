using System;
using LibExtension;

namespace ConsExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "1","3","5" };
            if ("5".In(animals))
                Console.WriteLine($"Found the animal!");
            else
                Console.WriteLine("No such animal.");
            Console.ReadKey();
        }
    }
}
