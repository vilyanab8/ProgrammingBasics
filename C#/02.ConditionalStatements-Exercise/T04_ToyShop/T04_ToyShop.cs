using System;
namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalPrice = puzzle * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
            int toys = puzzle + dolls + bears + minions + trucks;

            if (toys >= 50)
            {
                totalPrice = totalPrice - totalPrice * 25 / 100;
            }
            
            totalPrice = totalPrice - totalPrice * 10 / 100;
            double difference = totalPrice - tripPrice;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):F2}lv needed.");
            }
        }
    }
}

