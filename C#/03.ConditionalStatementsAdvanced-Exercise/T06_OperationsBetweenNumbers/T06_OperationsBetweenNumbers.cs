using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;

            if (operation == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
                }
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
                }
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
                }
            }
            else if (operation == "%")
            {
                if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
            else if (operation == "/")
            {
                if (num2 != 0) 
                { 
                    Console.WriteLine($"{num1} / {num2} = {num1 * 1.0 / num2:f2}"); 
                }
                else 
                { 
                    Console.WriteLine($"Cannot divide {num1} by zero"); 
                }
            }

        }
    }
}

