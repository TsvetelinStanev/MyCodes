using System;

namespace Speed_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a programm about speed limit (not a whole number) inserted from the client
            double speed = double.Parse(Console.ReadLine());

            //if it is between 0 and 10 write "slow", 50 till 150 fast, 150 till 1000 ulta fast , above 1000 exttremely fast
            if (speed <= 10) 
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50) 
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast"); 
            }
        }
    }
}
