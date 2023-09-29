using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string nameOfSeries = Console.ReadLine();
            int lenghtOfEpisode = int.Parse (Console.ReadLine());
            int lenghtOfBrake = int.Parse (Console.ReadLine());
            //calculations, we have time for lunch and rest 
            double timeForLunch = lenghtOfBrake * 0.125;
            double timeForRest = lenghtOfBrake * 0.25;
            //From lenght of the brake subtract lenght of the episode plus lenght of the lunch and rest
            double time = (lenghtOfBrake - (lenghtOfEpisode + timeForRest + timeForLunch));
            //output
            if (time>=0)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {Math.Ceiling(time)} minutes free time.");
            }
            else
            {
                double roundedTime = Math.Abs(time);
                roundedTime = Math.Ceiling(roundedTime);
                Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {roundedTime} more minutes.");
            }

        }
    }
}
