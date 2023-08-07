using System;
namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double percentPerYear = double.Parse(Console.ReadLine());

            double sum = ((depositSum * percentPerYear) / 1200);
            double totalSum = depositSum + depositTerm * sum;
            Console.WriteLine(totalSum);
        }
    }
}

