using System;
namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = min + (h * 60);
            int minAfter15Min = min + 15;
            int hAfter = minAfter15Min / 60;
            int mAfter = minAfter15Min % 60;

            if (hAfter > 23)
            {
                hAfter = 0;
            }

            if (mAfter < 10)
            {
                Console.WriteLine($"{hAfter}:0{mAfter}");
            }

            else
            {
                Console.WriteLine($"{hAfter}:{mAfter}");
            }
        }
    }
}

