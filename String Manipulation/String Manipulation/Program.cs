using System;

namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");

            int height = 168; //Centimeters, I ain't using fvcking imperial system
            int age = 21;
            string name = "Jesús Velázquez";
            string data = "Here's the stored data:\n" +
                $"Name: {name}\n" +
                $"Age: {age}\n" +
                $"Height: {height}";
            Console.WriteLine(data);
        }
    }
}
