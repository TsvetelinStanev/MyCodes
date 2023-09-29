using System;

namespace Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a programm which checks if a number is under 100, 100-200 or over 200
            int number = int.Parse (Console.ReadLine());

            if (number < 100) 
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200"); 
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
