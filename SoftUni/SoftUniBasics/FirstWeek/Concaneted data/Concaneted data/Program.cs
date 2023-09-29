using System;

namespace Concaneted_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse (Console.ReadLine());
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {city}.");

        }
    }
}
