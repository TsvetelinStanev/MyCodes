using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double puzzlePrice = 2.60;
            int talkingDollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            int truckPrice = 2;

            double priceExcursion = double.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numberTalkingDolls = int.Parse(Console.ReadLine());
            int numberBear = int.Parse(Console.ReadLine());
            int numberMinion = int.Parse(Console.ReadLine());
            int numberTruck = int.Parse(Console.ReadLine());
            //calculations
            double numberOfToys = numberTruck + numberTalkingDolls + numberMinion + numberPuzzles + numberBear;
            //if toys are over 50 calculations
            if (numberOfToys >= 50)
            {
                //calculating the revenue and than what's left after the 25% reduce and rent
                double sum = ((puzzlePrice * numberPuzzles) + (talkingDollPrice * numberTalkingDolls) + (bearPrice * numberBear) + (minionPrice * numberMinion) + (numberTruck * truckPrice))*0.75;
                double moneyLeftAfterRent = sum * 0.9;
                //if money left are more than the price for excursion
                if (moneyLeftAfterRent >= priceExcursion)
                {
                    Console.WriteLine($"Yes! {moneyLeftAfterRent - priceExcursion:f2} lv left.");
                }
                // if money left are less than money for excursion
                else
                {
                    Console.WriteLine($"Not enough money! {priceExcursion - moneyLeftAfterRent:f2} lv needed.");
                }
            }
            // if toys are under 50 calculations
            else
            {
                double sum = (puzzlePrice * numberPuzzles) + (talkingDollPrice * numberTalkingDolls) + (bearPrice * numberBear) + (minionPrice * numberMinion) + (numberTruck * truckPrice);
                double moneyLeftAfterRent = sum * 0.9;
                //if sum is more than price of excursion
                if (moneyLeftAfterRent >= priceExcursion)
                {
                    Console.WriteLine($"Yes! {moneyLeftAfterRent - priceExcursion:f2} lv left.");
                }
                // if money left are less than money for excursion
                else
                {
                    Console.WriteLine($"Not enough money! {priceExcursion - moneyLeftAfterRent:f2} lv needed.");
                }
            }
            
        }
    }
}
