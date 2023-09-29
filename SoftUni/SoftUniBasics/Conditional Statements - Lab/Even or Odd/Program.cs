using System;

namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to find whether the number inserted is even or not
            int number = int.Parse(Console.ReadLine());

            if (number%2 == 0) 
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
        }
    }
}
