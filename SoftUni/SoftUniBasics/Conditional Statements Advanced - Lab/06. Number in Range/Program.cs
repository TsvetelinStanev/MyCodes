using System;

namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали въведеното от потребителя число е в интервала [-100, 100] и е различно от 0
            //извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.
            //Input
            double number = double.Parse(Console.ReadLine());
            //Output
            if (number >= - 100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
