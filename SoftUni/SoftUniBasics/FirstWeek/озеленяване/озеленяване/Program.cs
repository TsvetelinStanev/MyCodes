using System;

namespace озеленяване
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeeter = (7.61);
            double discount = (0.18);
            double LastPriceWithoutDiscount = (squareMeeters * pricePerSquareMeeter);
            double discountPrice = (LastPriceWithoutDiscount * discount);
            double LastPrice = (LastPriceWithoutDiscount - discountPrice);
            Console.Write($"The final price is:{LastPrice} lv.");
            Console.Write($"The discount is: {discountPrice} lv.");
        }
    }
}
