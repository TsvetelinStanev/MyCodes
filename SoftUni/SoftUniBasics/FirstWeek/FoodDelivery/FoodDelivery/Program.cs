using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegymenu = 8.15;
            //input
            int numberChickenMenu = int.Parse (Console .ReadLine());   
            int numberFishMenu = int.Parse (Console .ReadLine());
            int numberVegyMenu = int.Parse (Console .ReadLine());
            // price of the whole order
            double priceChickenMenu = chickenMenu * numberChickenMenu;
            double priceFishMenu = fishMenu * numberFishMenu;
            double priceVegyMenu = vegymenu * numberVegyMenu;
            double desert = (priceChickenMenu + priceFishMenu + priceVegyMenu) * 0.20;
            double delivery = 2.50;
            double priceOfOrder = priceChickenMenu + priceFishMenu + priceVegyMenu + desert + delivery;
            Console.WriteLine(priceOfOrder);
        }
    }
}
