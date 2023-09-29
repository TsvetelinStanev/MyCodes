using System;

namespace USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolars = double.Parse (Console.ReadLine());
            double leva = dolars * 1.79549;
            Console.WriteLine(leva); 
        }
    }
}
