using System;

namespace Relational_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Welcome to Relational Operators");
            Console.WriteLine("Write a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write another number");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Number 1 is equal to number 2");
            }
            else
            {
                if (number1 > number2)
                {
                    Console.WriteLine("Number 1 is greater than number 2");
                }
                else
                {
                    Console.WriteLine("Number 2 is greater than number 1");
                }
            }
        }
    }
}
