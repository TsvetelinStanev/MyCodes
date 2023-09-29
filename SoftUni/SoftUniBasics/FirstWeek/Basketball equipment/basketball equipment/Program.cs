using System;

namespace basketball_equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse (Console.ReadLine());
            //Price of equipment
            double priceforshoees = yearlyTax * 0.60;
            double outfitekip = priceforshoees * 0.80;
            double basketball = outfitekip * 0.25;
            double accessories = basketball * 0.20;
            //Summing everything up
            double everything = yearlyTax + priceforshoees + outfitekip + accessories + basketball;
            Console.WriteLine(everything);
        }
    }
}
