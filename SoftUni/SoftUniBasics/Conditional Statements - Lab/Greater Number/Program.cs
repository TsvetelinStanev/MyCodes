using System;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //insert two whole numbers and pastes the greater one
            int num1 = int.Parse (Console.ReadLine());
            int num2 = int.Parse (Console.ReadLine()); 

            if (num1 > num2) 
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

        }
    }
}
