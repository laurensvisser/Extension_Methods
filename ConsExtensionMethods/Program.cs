using System;

namespace ConsExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "extension.method@visualstudio.net";
            Console.WriteLine($"{email} is emailadres: {email.IsValidEmailAddress()}");
            Console.ReadKey();
        }
    }
}

