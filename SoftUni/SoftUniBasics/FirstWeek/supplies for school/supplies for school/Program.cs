using System;

namespace supplies_for_school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PriceOfPens = 5.80;
            double PriceOfMarkers = 7.20;
            double PriceOfBelinaPerLiter = 1.20;
            int numberPens = int.Parse(Console.ReadLine());
            int numberMarkers = int.Parse(Console.ReadLine());
            int numberBelina = int.Parse(Console.ReadLine());
            int Discount = int.Parse(Console.ReadLine());
            double percentageDiscount = Discount / 100.0;
            double pricePens = PriceOfPens * numberPens;
            double priceMarkers = PriceOfMarkers * numberMarkers;
            double priceBelina = PriceOfBelinaPerLiter * numberBelina;
            //all calculations follow
            double priceForSupplies = pricePens + priceMarkers + priceBelina - ((priceMarkers + priceBelina + pricePens)*percentageDiscount);
            Console.WriteLine(priceForSupplies);

        }
    }
}
