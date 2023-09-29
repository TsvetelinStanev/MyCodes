using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double budgetPeter = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());
            //calculations
            double videocardprice = numberVideoCards * 250;
            double processorsprice = numberProcessors * (videocardprice * 0.35);
            double ramprice = ramMemory * (videocardprice * 0.10);
            double sumPrice = videocardprice + processorsprice + ramprice;

            if (numberVideoCards > numberProcessors)
            {
                sumPrice = sumPrice * 0.85;
            }
            //output
            if (sumPrice<=budgetPeter)
            {
                Console.WriteLine($"You have {budgetPeter - sumPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sumPrice - budgetPeter:f2} leva more!");
            }
        }
    }
}
