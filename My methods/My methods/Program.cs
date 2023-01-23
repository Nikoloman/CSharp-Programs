using System;

namespace My_methods
{
    internal class Program
    {
        // Void methods
        public void Addition(int a, int b)
        {
            int addition = a + b;
            Console.WriteLine($"The result of the addition is: {addition}");
        }

        public void Subtraction(int a, int b)
        {
            int subtraction = a - b;
            Console.WriteLine($"The result of the substraction is: {subtraction}");
        }

        // Return methods
        public int Multiplication(int a, int b)
        {
            int multiplication = a * b;
            return multiplication;
        }

        public float Division(int a, int b)
        {
            float division = a / b;
            return division;
        }

        static void Main(string[] args)
        {
            Program myMethods = new Program();

            int num1;
            int num2;
            int option;

            Console.WriteLine("Welcome to another calculator, this time with methods!");
            Console.WriteLine("Write the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation do you want to do?");
            Console.WriteLine("1.- Addition");
            Console.WriteLine("2.- Subtraction");
            Console.WriteLine("3.- Multiplication");
            Console.WriteLine("4.- Division");
            Console.WriteLine("Option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    myMethods.Addition(num1, num2);
                    break;
                case 2:
                    myMethods.Subtraction(num1, num2);
                    break;
                case 3:
                    int result;
                    result = myMethods.Multiplication(num1, num2);
                    Console.WriteLine($"The result of the multiplication is: {result}");
                    break;
                case 4:
                    float resultDivision;
                    resultDivision = myMethods.Division(num1, num2);
                    Console.WriteLine($"The result of the division is: {resultDivision}");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}
