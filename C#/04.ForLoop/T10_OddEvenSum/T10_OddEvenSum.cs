using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int counter = 0; counter < countOfInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }

            }
            if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
                }
            }
        }
    }

