using System;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int counter = 0; counter <= n; counter+= 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}

