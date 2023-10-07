using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int counter = 0; counter < countOfInputs; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += currentNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}

