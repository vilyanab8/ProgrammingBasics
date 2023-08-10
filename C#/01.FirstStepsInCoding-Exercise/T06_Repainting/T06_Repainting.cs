using System;
namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity = int.Parse(Console.ReadLine());
            double paintQuantity = double.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int worksHours = int.Parse(Console.ReadLine());

            paintQuantity = paintQuantity + paintQuantity * 0.10;
            nylonQuantity = nylonQuantity + 2;
            double nylonPrice = nylonQuantity * 1.5;
            double paintPrice = paintQuantity * 14.50;
            double thinnerPrice = thinnerLiters * 5.00;
            double materialsSum = nylonPrice + paintPrice + thinnerPrice + 0.40;

            double pricePerHours = materialsSum * 0.30;
            double worksSum = worksHours * pricePerHours;
            double totalSum = worksSum + materialsSum;
            Console.WriteLine(totalSum);
        }
    }
}


