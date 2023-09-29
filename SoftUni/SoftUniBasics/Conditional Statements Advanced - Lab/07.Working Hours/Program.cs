using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) -
            //въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа,
            //от понеделник до събота включително
            //Input
            int number = int.Parse (Console.ReadLine());
            string day = Console.ReadLine ();
            //Calculations
            //Start with day then with hours
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (number >= 10 && number <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                        Console.WriteLine("closed");
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
            }
        }
    }
}
