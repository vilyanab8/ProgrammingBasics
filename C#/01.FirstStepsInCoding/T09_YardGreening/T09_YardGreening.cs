using System;
namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetre = double.Parse(Console.ReadLine());
            double squareMetrePrice = 7.61;
            double finalPrice = squareMetre * squareMetrePrice;
            double discount = finalPrice * 0.18;
            double totalPrice = finalPrice - discount;

            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}


