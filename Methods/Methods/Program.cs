using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numberArray;

            numberArray = new float[10] { 1.5f, 5.1f, 2.5f, 4.8f, 9.5f, 2.9f, 8.5f, 6.2f, 1.9f, 7.5f };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, 9);
            Console.WriteLine("Welcome to random");
            Console.WriteLine($"The random index is: {randomIndex} and in the array is: {numberArray[randomIndex]}");

        }
    }
}
