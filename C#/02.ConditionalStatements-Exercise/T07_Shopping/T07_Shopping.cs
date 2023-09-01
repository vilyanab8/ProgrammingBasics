using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 
            double budget = double.Parse(Console.ReadLine());
            int gpuNum = int.Parse(Console.ReadLine());
            int cpuNum = int.Parse(Console.ReadLine());
            int ramNum = int.Parse(Console.ReadLine());

            // Prices 
            double gpuPrice = 250 * gpuNum;
            // 35 procents of gpu numbers
            double cpuPrice = gpuPrice * 0.35 * cpuNum;
            double ramPrice = (gpuPrice * 0.1) * ramNum;
            double totalSum = gpuPrice + cpuPrice + ramPrice;

            if (gpuNum > cpuNum)
            {
                totalSum = totalSum * 0.85;
            }
            double moneyLeft = budget - totalSum;
            double moneyNeeded = totalSum - budget;

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else if (totalSum > budget)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):f2} leva more!");
            }

        }
    }
}
