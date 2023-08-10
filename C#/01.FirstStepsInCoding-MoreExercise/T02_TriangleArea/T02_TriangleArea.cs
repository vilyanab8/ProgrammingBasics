using System;
namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = side * h / 2;
            Console.WriteLine("{0:f2}",area);
        }
    }
}


