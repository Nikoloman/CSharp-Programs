using System;

namespace Numeric_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;

            Console.WriteLine("Welcome to the calculator, write a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great, now write the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            result = number1 + number2;
            Console.WriteLine("The result is: " + result);
        }
    }
}
