using System;

namespace Inches_to_centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double inchesForConvert = inch;
            double centimeters = inchesForConvert * 2.54; 
            Console.WriteLine(centimeters);
        }
    }
}
