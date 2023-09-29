using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int hours = int.Parse (Console.ReadLine());
            int minutes = int.Parse (Console.ReadLine())+15;
            //calculations
            //minutes converting
           if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60; 
            }
            //Hours converting
           if (hours >=24)
            {
                hours = hours - 24;
            }
            //adding the zero in case seconds are less than 10
            //output
            if (minutes <10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
