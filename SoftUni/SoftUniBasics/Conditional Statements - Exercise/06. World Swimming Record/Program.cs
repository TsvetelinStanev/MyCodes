using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            //calculations
            double howMuchHeSlowed = Math.Floor(meters / 15);
            double time = meters * secondsPerMeter;
            time += howMuchHeSlowed * 12.5;
            //output
            if (time < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {time - record:f2} seconds slower.");
            }
        }
    }
}
