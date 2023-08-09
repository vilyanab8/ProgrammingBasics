using System;
namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFruit = int.Parse(Console.ReadLine());

            double sum = vegPrice * totalKgVeg;
            double sum1 = fruitPrice * totalKgFruit;
            double totalSum = sum + sum1;
            double endSum = totalSum / 1.94;
            Console.WriteLine("{0:f2}",endSum);
        }
    }
}

