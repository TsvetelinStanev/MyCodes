﻿using System;

namespace _10._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло число
            //въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 
            //Input
            double number = double.Parse(Console.ReadLine());
            //Output
            if ((number >= 100 && number <= 200) || number == 0)
            {

            }
            else
                Console.WriteLine("invalid");
        }
    }
}
