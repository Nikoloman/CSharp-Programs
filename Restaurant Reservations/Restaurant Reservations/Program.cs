using System;

namespace Restaurant_Reservations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = new string[10] {"Nikolo", "Redman", "Michmishi", "aran.dano", "", "", "", "", "", ""};
            int arrayCurrentIndex = 4;
            bool registeredUser;

            Console.WriteLine("Welcome to Tacos el Tommy!");

            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("Are you a registered user? Write true, or false to register");
                registeredUser = Convert.ToBoolean(Console.ReadLine());

                if (registeredUser)
                {
                    Console.WriteLine("Hey there! Enter your exact user name: ");
                    string userToSearch = Console.ReadLine();

                    int index = Array.IndexOf(usernames, userToSearch);

                    if (index == -1)
                    {
                        Console.WriteLine("User name not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome {usernames[index]}");
                    }
                }
                else if (!registeredUser)
                {
                    Console.WriteLine("Please write and remember your user name: ");
                    usernames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved succesfully");
                    Console.WriteLine($"Your username is '{usernames[arrayCurrentIndex]}'");
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("The restaurant is full, try again later");
            Console.WriteLine("Here´s the whole list of clients: ");

            foreach (string client in usernames)
            {
                Console.WriteLine(client);
            }
        }
    }
}
