using System;

namespace _01._Day_of_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //Whole number, written by the customer, going to a specific day in the week 
            //From 1 till 7 are the days 
            int number = int.Parse (Console.ReadLine());
            //Calculations
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
            //Output
        }
    }
}
