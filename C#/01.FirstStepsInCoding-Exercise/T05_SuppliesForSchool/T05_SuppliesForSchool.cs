using System;
namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int hPackets = int.Parse(Console.ReadLine());
            int mPackets = int.Parse(Console.ReadLine());
            int prLiters = int.Parse(Console.ReadLine());
            int percentSale = int.Parse(Console.ReadLine());

            double hPrice = hPackets * 5.80;
            double mPrice = mPackets * 7.20;
            double prPrice = prLiters * 1.20;
            double totalPrice = hPrice + mPrice + prPrice;
            double totalSale = ((totalPrice * percentSale) / 100);
            double totalPriceSale = totalPrice - totalSale;
            Console.WriteLine(totalPriceSale);
        }
    }
}

