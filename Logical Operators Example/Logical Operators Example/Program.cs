using System;

namespace Logical_Operators_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            bool result;

            // &&
            result = value1 && value2 && value3;
            Console.WriteLine($"value1 && value2 && value3 = {result}");

            // ||
            result = value1 || value2 || value3;
            Console.WriteLine($"value1 || value2 || value3 = {result}");

            // Mixed
            result = value1 || value2 && value3;
            Console.WriteLine($"value1 || value2 && value3 = {result}");

            // !
            result = !value1;
            Console.WriteLine($"!value1 = {result}");
        }
    }
}
