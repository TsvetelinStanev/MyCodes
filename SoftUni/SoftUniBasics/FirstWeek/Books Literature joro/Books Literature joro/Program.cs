using System;

namespace Books_Literature_joro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPagesOfTheCurrentBook = int.Parse (Console.ReadLine());
            int numberHeReadsPerHour = int.Parse (Console.ReadLine());
            int numberOfDaysInWhichHeNeedsToReadTheBook = int.Parse (Console.ReadLine());

            int hours = numberOfPagesOfTheCurrentBook / numberHeReadsPerHour / numberOfDaysInWhichHeNeedsToReadTheBook;
            Console.WriteLine (hours);
        }
    }
}
