using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            //ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (реално число) ,
            //въведени от потребителя, и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
            //При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".

            //Normal day price/Weekend price

            //banana - 2.50/2.70
            //apple - 1.20/ 1.25
            //orange - 0.85/ 0.90
            //grapefruit - 1.45/ 1.60
            //kiwi - 2.70/ 3.00
            //pineapple - 5.50/ 5.60
            //grapes - 3.85/ 4.20

            // days of week:
            //Monday
            //Tuesday
            //Wednesday
            //Thursday
            //Friday
            //Saturday
            //Sunday
            //Input
            string fruitName = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //Output
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    //Writing the fruit name and calculating the price quantity * price of fruit
                    switch (fruitName)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.50:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.20:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.85:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.45:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 2.70:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.50:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 3.85:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruitName)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.70:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.25:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.90:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.60:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 3.00:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.60:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 4.20:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
