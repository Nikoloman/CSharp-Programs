using System;

namespace Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Values of the rectangle
            float sideA;
            float sideB;

            //Requesting values
            Console.WriteLine("Area of a rectangle");

            Console.WriteLine("Write the value of the first side: ");
            sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Write the value of the second side: ");
            sideB = float.Parse(Console.ReadLine());

            //Area formula
            float area = sideA * sideB;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
    }
}
