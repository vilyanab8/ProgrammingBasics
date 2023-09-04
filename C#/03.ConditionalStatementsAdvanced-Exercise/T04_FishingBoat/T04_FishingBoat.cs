using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double priceForBoat = 0.0;
            double price = 0.0;
            double sum = 0.0;

            if (season == "Spring")
            {
                priceForBoat = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceForBoat = 4200;
            }
            else if (season == "Winter")
            {
                priceForBoat = 2600;
            }

            if (fishermanCount <= 6)
            {
                price = priceForBoat - priceForBoat * 0.1;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                price = priceForBoat - priceForBoat * 0.15;
            }
            else if (fishermanCount >= 12)
            {
                price = priceForBoat - priceForBoat * 0.25;
            }

            if (season == "Spring" || season == "Summer" || season == "Winter")
            {
                if (fishermanCount % 2 == 0)
                {
                    price = price - price * 0.05;
                }
            }
            double sum1 = budget - price;
            double sum2 = price - budget;
            if (budget <= price)
            {
                Console.WriteLine($"Not enough money! You need {sum2:f2} leva.");
            }
            else if (budget > price)
            {
                Console.WriteLine($"Yes! You have {sum1:f2} leva left.");
            }
        }
    }
}

