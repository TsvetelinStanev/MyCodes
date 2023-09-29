using System;

namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input - age (whole number), gender "f"/ "m"
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //calculations
            //First whether it's a man or a woman 
            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                    Console.WriteLine("Master");
            }
            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else 
                {
                    Console.WriteLine("Miss");
                }
            } 
            //Output "Mr." – мъж (пол 'm') на 16 или повече години
            //"Master" – момче(пол 'm') под 16 години//
            //"Ms." – жена(пол 'f') на 16 или повече години
            //"Miss" – момиче(пол 'f') под 16 години
        }
    }
}
