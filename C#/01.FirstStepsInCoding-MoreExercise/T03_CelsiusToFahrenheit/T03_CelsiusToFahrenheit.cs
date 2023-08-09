using System;
namespace Celsius_to_Farenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double farenhait = (celcius * 9)/5 + 32;
            Console.WriteLine("{0:f2}",farenhait);
        }
    }
}

