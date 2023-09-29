using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.

            //Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes

            //Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot

            //Всички останали са "unknown"
            
            //Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт.
            //Input
            string name = Console.ReadLine();
            //Output
            switch (name)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
