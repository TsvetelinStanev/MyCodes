using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double priceForClothingPerArtist = double.Parse(Console.ReadLine());

            //Calculations
            double decor = budget * 0.10; 
            if (numberStatists > 150)
            {
                priceForClothingPerArtist = priceForClothingPerArtist * 0.90; 
            }
            double moneyPaidForDecorAndClothing = priceForClothingPerArtist *numberStatists + decor;
            //Output
            if (moneyPaidForDecorAndClothing > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyPaidForDecorAndClothing - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyPaidForDecorAndClothing:f2} leva left.");
            }
        }
    }
}
