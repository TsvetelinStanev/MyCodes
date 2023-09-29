using System;
using System.Threading;

namespace Conditional_Statements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int racer1Seconds = int.Parse (Console.ReadLine());
            int racer2Seconds = int.Parse (Console.ReadLine());
            int racer3Seconds = int.Parse (Console.ReadLine());

            //calculations
            int sumSeconds = racer1Seconds + racer2Seconds + racer3Seconds;
            int minutes = sumSeconds / 60;
            double seconds = sumSeconds % 60;
            //output
            if (seconds <10 )
            {
                Console.WriteLine ($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine ($"{minutes}:{seconds}");
            }
        }
    }
}
