using System;
namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = countChickenMenu * 10.35;
            double fishMenuPrice = countFishMenu * 12.40;
            double vegetarianMenuPrice = countVegetarianMenu * 8.15;
            double menuSum = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
            double desert = menuSum * 0.2;
            double totalSum = menuSum + desert + 2.50;
            Console.WriteLine(totalSum);
        }
    }
}

