using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Условието на задачата

            //Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) ,
            //въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица.
            //Резултатът да се изведе форматиран до 2 цифри след десетичната точка.
            //При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 

            //Input
            string cityName = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            //Only options for cities are Sofia, Varna and Plovdiv, if it is another city it is error 
            if (cityName == "Sofia" || cityName == "Varna" || cityName == "Plovdiv")
            {
                //Given commissions for different cities based on the volume of sales , if the commission is negative it writes "error".
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    double commissionSofia = 0.05;
                    double commissionVarna = 0.045;
                    double commissionPlovdiv = 0.055;

                    //Calculating how much the person earned with the commission till the second decimal if the sales volume is >=0;<=500.
                    if (cityName == "Sofia")
                    {
                        Console.WriteLine($"{salesVolume * commissionSofia:f2}");
                    }
                    else if (cityName == "Varna")
                    {
                        Console.WriteLine($"{salesVolume * commissionVarna:f2}");
                    }
                    else if (cityName == "Plovdiv")
                    {
                        Console.WriteLine($"{salesVolume * commissionPlovdiv:f2}");
                    }

                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    double commissionSofia = 0.07;
                    double commissionVarna = 0.075;
                    double commissionPlovdiv = 0.08;

                    //Calculating how much the person earned with the commission till the second decimal if the sales volume is >500; <=1000
                    if (cityName == "Sofia")
                    {
                        Console.WriteLine($"{salesVolume * commissionSofia:f2}");
                    }
                    else if (cityName == "Varna")
                    {
                        Console.WriteLine($"{salesVolume * commissionVarna:f2}");
                    }
                    else if (cityName == "Plovdiv")
                    {
                        Console.WriteLine($"{salesVolume * commissionPlovdiv:f2}");
                    }
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    double commissionSofia = 0.08;
                    double commissionVarna = 0.10;
                    double commissionPlovdiv = 0.12;

                    //Calculating how much the person earned with the commission till the second devcimal if the sales volume is >1000; <= 10 000
                    if (cityName == "Sofia")
                    {
                        Console.WriteLine($"{salesVolume * commissionSofia:f2}");
                    }
                    else if (cityName == "Varna")
                    {
                        Console.WriteLine($"{salesVolume * commissionVarna:f2}");
                    }
                    else if (cityName == "Plovdiv")
                    {
                        Console.WriteLine($"{salesVolume * commissionPlovdiv:f2}");
                    }
                }
                else if (salesVolume > 10000)
                {
                    double commissionSofia = 0.12;
                    double commissionVarna = 0.13;
                    double commissionPlovdiv = 0.145;

                    //Calculating how much the person earned with the commission till the second decimal. If the sales volume is >10 000
                    if (cityName == "Sofia")
                    {
                        Console.WriteLine($"{salesVolume * commissionSofia:f2}");
                    }
                    else if (cityName == "Varna")
                    {
                        Console.WriteLine($"{salesVolume * commissionVarna:f2}");
                    }
                    else if (cityName == "Plovdiv")
                    {
                        Console.WriteLine($"{salesVolume * commissionPlovdiv:f2}");
                    }
                }
                //The sales volume is negative, it shows "error"
                else
                {
                    Console.WriteLine("error");
                }
            }
            //The city is not Sofia, Varna, Plovdiv, it shows "negative"
            else { Console.WriteLine("error"); }
        }
    }
}
