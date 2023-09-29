using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DfoodPrice = 2.50; 
            int CFoodPrice = 4;
            byte numPackFoodForDogs = byte.Parse(Console.ReadLine());
            byte numberPackagesFoodForCats = byte.Parse(Console.ReadLine());
            double dogFoodSubtotal = DfoodPrice * numPackFoodForDogs;
            double catFoodSubtotal = CFoodPrice * numberPackagesFoodForCats;
            double endsum = dogFoodSubtotal+catFoodSubtotal;
            Console.Write($"{endsum} lv.");
        }
    }
}
