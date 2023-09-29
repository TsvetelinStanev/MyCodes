using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input cm make it in dm by deviding by 10
            double lenght = double.Parse (Console.ReadLine())/10;
            double width = double.Parse (Console.ReadLine())/10;
            double height = double.Parse (Console.ReadLine())/10;
            //filled means all things tht fill the aquarium additionally such as pump
            double percentageoffilled = double.Parse (Console.ReadLine())/100.0;
            //calculate liters
            double space =(lenght * width * height) * (1 - percentageoffilled);
            Console.WriteLine(space);
        }
    }
}
