using System;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesús Velázquez";
            string job = "CEO of smth";

            // Clone: copies the exact string to a new one
            string nameClone = name.Clone().ToString();
            Console.WriteLine(nameClone);

            // CompareTo:
            Console.WriteLine(job.CompareTo(name));
            Console.WriteLine(name.CompareTo(nameClone));

            // Contains
            Console.WriteLine(job.Contains("of"));

            // EndsWith
            Console.WriteLine(job.EndsWith("th"));

            // StartsWith
            Console.WriteLine(job.StartsWith("CE"));

            // Equals
            Console.WriteLine(name.Equals(nameClone));

            // IndexOf
            Console.WriteLine(name.IndexOf("e"));

            // ToUpper
            Console.WriteLine(job.ToUpper());

            // ToLower
            Console.WriteLine(job.ToLower());

            // Insert
            Console.WriteLine(job.Insert(11, " I don´t know"));

            // LastIndexOf
            Console.WriteLine(name.LastIndexOf("z"));

            // Remove
            Console.WriteLine(name.Remove(3));

            // Replace
            Console.WriteLine(name.Replace("s", "j"));

            // Substring
            Console.WriteLine(job.Substring(0, 3));
        }
    }
}
