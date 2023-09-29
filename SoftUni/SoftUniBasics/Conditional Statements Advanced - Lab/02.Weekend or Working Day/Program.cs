using System;

namespace _02.Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write if a day is working day or weekend, if it is neither then write error
            //Input
            string day = Console.ReadLine();
            //calculations
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
