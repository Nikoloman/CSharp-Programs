using System;

namespace String_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + userName + ". Have a nice day.");
        }
    }
}
