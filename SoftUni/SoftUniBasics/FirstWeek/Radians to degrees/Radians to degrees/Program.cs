using System;

namespace Radians_to_degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInRadians = double.Parse (Console.ReadLine());
            double degrees = angleInRadians * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
