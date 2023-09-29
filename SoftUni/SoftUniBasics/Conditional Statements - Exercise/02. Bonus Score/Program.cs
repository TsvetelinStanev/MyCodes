using System;
using System.Net;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            //calculations
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = points * 0.2;
            }
            else 
            {
                bonusPoints = points * 0.1;
            }
            if (points%2 == 0)
            {
                bonusPoints++;
            }
            else if (points%10 == 5)
            {
                bonusPoints += 2;
            }
            //output
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
