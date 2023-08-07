using System;
namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());

            double shoesPrice = taxPerYear - taxPerYear * 0.4;
            double outfitPrice = shoesPrice - shoesPrice * 0.2;
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            double totalSum = shoesPrice + taxPerYear + outfitPrice + ballPrice + accPrice;
            Console.WriteLine(totalSum);
        }
    }
}

