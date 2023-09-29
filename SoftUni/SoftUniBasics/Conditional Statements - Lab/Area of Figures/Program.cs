using System;
using System.Drawing;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a programm about area of figures
            //The figures can be square, rectangle, circle, triangle
            string figure = Console.ReadLine();
            //After the figure is given, the numbers needed to calculate the area are given
            if (figure == "square")
            //For square it is S=a*a
            {
                double a = double.Parse (Console.ReadLine());
                double Ssquare = a * a;
                Console.WriteLine($"{Ssquare:f3}");
            }
            else if (figure == "rectangle")
            //For rectangle it is S=a*b
            {
                double a = double.Parse (Console.ReadLine());
                double b = double.Parse (Console.ReadLine());
                double sRectangle = a * b;
                Console.WriteLine($"{sRectangle:f3}");
            }
            else if (figure == "circle")
            //For circle it is S=Pi*r*r
            {
                double r = double.Parse (Console.ReadLine());
                double sCircle = Math.PI * r * r;
                Console.WriteLine($"{sCircle:f3}");
            }
            else if (figure == "triangle")
            //For triangle it is S=a*ha/2
            {
                double a = double.Parse (Console.ReadLine());
                double ha = double.Parse (Console.ReadLine());
                double sTriangle = (a * ha) / 2;
                Console.WriteLine($"{sTriangle:f3}");
            }
        }
    }
}
