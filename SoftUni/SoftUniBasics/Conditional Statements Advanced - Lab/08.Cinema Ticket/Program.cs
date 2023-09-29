using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма която чете ден от седмицата (текст) –
            //въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:
            //Monday - 12, Tuesday - 12, Wednesday - 14 , Thursday - 14, Friday - 12, Saturday - 16, Sunday - 16
            //Input
            string day = Console.ReadLine();
            //Output
            switch (day)
            {
                case "Monday":
                    Console.WriteLine(12);
                    break;
                case "Tuesday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                    Console.WriteLine(14);
                    break;
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Saturday":
                    Console.WriteLine(16);
                    break;
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
