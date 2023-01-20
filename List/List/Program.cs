using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tacos el Güero\n");

            List<string> tacoShoppingList = new List<string>();
            tacoShoppingList.Add("Five tacos de asada");    // 5 de asada espaiderman
            tacoShoppingList.Add("Two tacos de pastor");
            tacoShoppingList.Add("Four tacos de tripa");    // The best of the best if you ask me
            tacoShoppingList.Add("One taco de chorizo");
            tacoShoppingList.Add("Four Cocas");             // Coke, not the drug

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            tacoShoppingList.Remove("One taco de chorizo"); // Removing by the element
            tacoShoppingList.RemoveAt(0);                   // Removing by index

            Console.WriteLine();
            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }
        }
    }
}
