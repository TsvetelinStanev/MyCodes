using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse (Console.ReadLine());
            int timeOfdepositInMonths = int.Parse (Console.ReadLine ());
            double yearlyInterestRate = double.Parse (Console.ReadLine ());
            double yearlyInterestRateInPercentage = yearlyInterestRate / 100;
            double sum = deposit + timeOfdepositInMonths * ((deposit * yearlyInterestRateInPercentage)/12);
            Console.WriteLine(sum);
        }
    }
}
