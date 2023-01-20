using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to starbucks coffee");

            // Arrays
            string[] coffeeTypes;
            float[] coffeePrice;

            coffeeTypes = new string[] { "Expresso", "Caramel Macchiato", "Frappuccino", "Latte"};
            coffeePrice = new float[] { 1.2f, 2.3f, 2.45f, 2.75f }; // I don't go to Starbucks very often tho

            coffeeTypes[2] = "Mocha"; // Changing a value

            for (int i = 0; i < coffeeTypes.Length; i++)
            {
                Console.WriteLine($"{coffeeTypes[i]} coffee, Price: ${coffeePrice[i]}");
            }
        }
    }
}
