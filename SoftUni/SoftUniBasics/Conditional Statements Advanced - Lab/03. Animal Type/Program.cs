using System;
using System.Xml.Linq;

namespace _03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //1. dog -> mammal
            // 2.crocodile, tortoise, snake->reptile
            // 3.others->unknown
            string animal = Console.ReadLine();
            //Calculations
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown"); 
                    break;
            }
        }
    }
}
