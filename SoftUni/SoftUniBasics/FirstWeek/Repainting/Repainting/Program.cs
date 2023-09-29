using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double safetyNailonPerSquareMeeter = 1.50;
            double paintPerLiter = 14.50;
            int razreditelThinnerInEnglish = 5;
            //Input
            int nailon = int.Parse (Console.ReadLine())+2;
            int paint = int.Parse (Console.ReadLine());
            double realPaint = paint * (110.0 / 100.0);
            int Thinner = int.Parse(Console.ReadLine());
            int hoursTodoTheWork = int.Parse (Console.ReadLine());
            //money to be spend
            double torbichkisuma = 0.40;
            double sumforPaint = paintPerLiter * realPaint;
            double sumforThinner = razreditelThinnerInEnglish * Thinner;
            double sumforNailon = nailon * safetyNailonPerSquareMeeter;
            //sum for every material and than workforce calculated 
            double sumofeverymaterial = sumforNailon + sumforPaint + sumforThinner + torbichkisuma;
            double payforworkforce = sumofeverymaterial * 0.30 * hoursTodoTheWork;
            double everything = sumofeverymaterial + payforworkforce;
            Console.WriteLine(everything);
        }
    }
}
